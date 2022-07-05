// Nhap "ON", "OFF" de bat/tat LED on board
// Nhap REBOOT de reset board
// Nhap "<REAL>F", "<REAL>R" de quay thuan nguoc, vd: 0.90F hay 0.5124830R

#include <stdio.h>
#include <string.h>
#include "stdlib.h"
#include "pico/stdlib.h"
#include "pico/bootrom.h"
#include "pico/binary_info.h"
#include "pico/time.h"
#include "hardware/pwm.h"
#include "hardware/pio.h"
#include "hardware/gpio.h"
#include "hardware/timer.h"

#include "quadrature_encoder.pio.h"

#define A_PIN 8		// PIN xuat pwm
#define B_PIN 9
#define WRAP 65535	// WRAP+1 la chu ki PWM
#define EN_A 10		// PIN encoder
#define EN_B 11
#define PPR 8000	//so xung toi da cua encoder
#define SAMPLE_TIME 500 // Thoi gian lay mau ms

#define ENDSTDIN	255
#define CR	13


#define LED_PIN 25

double velocity = 0;
int position = 0;
int new_value, delta, old_value = 0;
uint64_t new_time, old_time;
PIO pio = pio0;
const uint sm = 0;


bool repeating_timer_callback(struct repeating_timer *t) {
	// note: thanks to two's complement arithmetic delta will always
    // be correct even when new_value wraps around MAXINT / MININT
	new_value = quadrature_encoder_get_count(pio, sm);
	new_time = time_us_64();
	delta = new_value - old_value;
	velocity = delta/((new_time-old_time)*1e-6);
	position = new_value;	//ko chinh cho vi tri ve 0 khi qua 8000 duoc vi phai sua ct torng file .pio
	old_value = new_value;
	old_time = new_time;

	// Thay lenh printf nay bang frame nhan ve mong muon
	printf("%ldP\n",position);
	printf("%lfV\n",velocity);
    //printf("position %8d, velocity %lf\n", position, velocity);

    return true;
}

int main() {
	stdio_init_all();
	char buffer[1024];

	gpio_init(LED_PIN);
	gpio_set_dir(LED_PIN, GPIO_OUT);

	// PWM-------------------------------------------------------------------
	gpio_set_function(A_PIN, GPIO_FUNC_PWM);
    gpio_set_function(B_PIN, GPIO_FUNC_PWM);
    uint slice_num = pwm_gpio_to_slice_num(A_PIN);

    // Get some sensible defaults for the slice configuration. By default, the
    // counter is allowed to wrap over its maximum range (0 to 2**16-1)
    pwm_config config = pwm_get_default_config();
	pwm_set_wrap(slice_num, WRAP);
    // Load the configuration into our PWM slice, and set it running.
    pwm_init(slice_num, &config, true);
   
   	// ENCODER-----------------------------------------------------------------
	// int new_value, delta, old_value = 0;
	// uint64_t new_time, old_time = time_us_64();
	old_time = time_us_64();

    // Base pin to connect the A phase of the encoder.
    // The B phase must be connected to the next pin
    const uint PIN_AB = EN_A;

    // PIO pio = pio0;
    // const uint sm = 0;

    uint offset = pio_add_program(pio, &quadrature_encoder_program);
    quadrature_encoder_program_init(pio, sm, offset, PIN_AB, 0);

	struct repeating_timer timer;
    add_repeating_timer_ms(SAMPLE_TIME, repeating_timer_callback, NULL, &timer);

	//LOOP-------------------------------------------------------------
	while(1)
	{
		scanf("%1024s", buffer);
		printf("%s\n", buffer);
		if (strcmp(buffer, "ON") == 0)
		{
			gpio_put(LED_PIN, 1);
		} else if (strcmp(buffer, "OFF") == 0)
		{
			gpio_put(LED_PIN, 0);
		} else if (strcmp(buffer, "REBOOT") == 0)
		{
			reset_usb_boot(0,0);
		}
		else
		{
			char *ptr;
   			double ret;

  		 	ret = strtod(buffer, &ptr);
   			// printf("The number(double) is %lf\n", ret);
   			// printf("String part is |%s|\n", ptr);

			uint16_t cv = WRAP*ret;
			
			if (strcmp(ptr, "F") == 0)
			{
				pwm_set_gpio_level(A_PIN, cv);
    			pwm_set_gpio_level(B_PIN, 0);
				printf("Channel level is %u/%lu forward\n",cv,WRAP);
			}
			else if (strcmp(ptr, "R") == 0)
			{
				pwm_set_gpio_level(A_PIN, 0);
    			pwm_set_gpio_level(B_PIN, cv);
				printf("Channel level is %u/%lu reverse\n",cv,WRAP);
			}
		}
		
        sleep_ms(100);
	}	

}

