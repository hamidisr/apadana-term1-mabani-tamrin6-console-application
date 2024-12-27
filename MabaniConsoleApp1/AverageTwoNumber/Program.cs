using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MabaniConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstInput, secondInput;
            float firstNum, secondNum, mean;
            
            Console.WriteLine("Enter two numbers in seperate lines:");

            firstInput = Console.ReadLine();
            secondInput = Console.ReadLine();

            firstNum = float.Parse(firstInput);
            secondNum = float.Parse(secondInput);

            mean = (firstNum + secondNum) / 2;

            Console.Write("Average is: ");
            Console.Write(mean);

            Console.ReadKey();
        }
    }
}
