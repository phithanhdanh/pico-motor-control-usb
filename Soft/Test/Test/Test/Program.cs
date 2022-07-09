using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* My using System */
using System.IO;
using System.IO.Ports;
using System.Xml;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "12";

            //reading all characters as byte and storing them to byte[]
            byte[] barr = Encoding.ASCII.GetBytes(str);

            //printing characters with byte values
            for (int loop = 0; loop < barr.Length; loop++)
            {
                Console.WriteLine("Byte of char \'" + str[loop] + "\' : " + (barr[loop]));
            }


            byte[] bar = BitConverter.GetBytes(Convert.ToByte(str));
            for (int loop = 0; loop < bar.Length; loop++)
            {
                Console.WriteLine("Byte of char \'" + str[loop] + "\' : " + (bar[loop]));
            }

            //byte[] kp = BitConverter.GetBytes(Convert.ToDouble(str));
            //byte[] kp = BitConverter.GetBytes(str);
            //for (int i = 0; i< kp.Length -1; i++)
            //{
            //    Console.WriteLine(kp[i]);
            //}

            //hit ENTER to exit
            Console.ReadLine();
        }
    }
}
