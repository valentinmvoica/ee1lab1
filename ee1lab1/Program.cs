using System;
using System.Collections.Generic;

namespace ee1lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Scrieti un program care va calcula valoarea urmatoarei functii pentru x citit de la tastatura
             */

            Console.WriteLine("introduceti x");
            double x = double.Parse(Console.ReadLine());

            if (x <= -2)
            {
                Console.WriteLine(7 * x * x);
            } else if (x <= 0.5)
            {
                Console.WriteLine(4 * x - 5);
            }
            else 
            {
                Console.WriteLine(14 * x - 5);
            }
        }
    }
}
