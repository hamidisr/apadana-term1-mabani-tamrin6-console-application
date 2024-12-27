using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSwiper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInput, secondInput;
            float firstNum, secondNum, temp;

            Console.WriteLine("Enter two numbers in seperate lines:");

            firstInput = Console.ReadLine();
            secondInput = Console.ReadLine();

            firstNum = float.Parse(firstInput);
            secondNum = float.Parse(secondInput);

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;

            Console.Write("first number is: ");
            Console.WriteLine(firstNum);

            Console.Write("second number is: ");
            Console.WriteLine(secondNum);

            Console.ReadKey();
        }
    }
}
