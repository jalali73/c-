using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static int[] mod = new int[8];
        static void convert(int number)
        {
            int i = 0;
            while (number != 0)
            {
                mod[i] = number % 2;
                number = number / 2;
                i++;
            }
            for (int j = 7; j >= 0; j--)
            {
                Console.Write(mod[j]);
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int div;
            div = int.Parse(Console.ReadLine());
            convert(div);
        }


    }
}


