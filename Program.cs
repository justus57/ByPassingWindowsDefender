using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByPassingWindowsDefender
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buf = new byte[0] { };

            byte[] encoded = new byte[buf.Length];

            for (int i = 0; i < buf.Length; i++)
            {
                encoded[i] = (byte)(((uint)buf[i] ^ 0xAA) & 0xFF);
            }
            StringBuilder hex = new StringBuilder(encoded.Length * 2);

            foreach (byte b in encoded)
            {

                hex.AppendFormat("0x{0:x2}, ", b);

            }

            Console.WriteLine("The payload is: " + hex.ToString());
        }
    }
}
