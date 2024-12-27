using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            float num;

            Console.WriteLine("Enter your grade:");

            input = Console.ReadLine();

            num = float.Parse(input);

            if (num < 10)
            {
                Console.Write("Faild");
            }
            else
            {
                Console.WriteLine("Pass");
            }

            Console.ReadKey();
        }
    }
}
