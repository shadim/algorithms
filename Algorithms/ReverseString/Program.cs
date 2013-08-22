using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] realstring = "123456789abcd".ToCharArray();
            
            int len =  realstring.Length;

            Console.WriteLine("Original String:{0}",new String(realstring));

            for (int i = 0; i < len/2; i++)
            {
                char lowerchar = realstring[i];

                realstring[i] = realstring[len - i - 1];

                realstring[len - i-1] = lowerchar;
            }

            Console.WriteLine("Reverse String:{0}",new String(realstring));

            Console.ReadKey();
        }
    }
}
