//takes two numbers from console and displays maximum 

using System;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            var max = number1 > number2 ? number1 : number2;
            Console.WriteLine("max is {0}",max);
        }
    }
}
