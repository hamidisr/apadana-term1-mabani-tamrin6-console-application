using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            float num;

            Console.WriteLine("Enter your number:");

            input = Console.ReadLine();

            num = float.Parse(input);

            if (num % 2 == 0)
            {
                Console.Write("result is: ");
                Console.Write(num * 2);
            }
            else
            {
                Console.WriteLine("result is: ");
                Console.Write(num / 2);
            }

            Console.ReadKey();
        }
    }
}
