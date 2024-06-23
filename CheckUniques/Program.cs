using System;
using System.Collections.Generic;

//ask user to continuously enter a number or type "Quit" to exit. list of numbers may include duplicates. Display unique.

namespace Example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or write quit:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();
            foreach (var num in numbers)
                if (!uniques.Contains(num))
                    uniques.Add(num);

            foreach (var num in uniques) Console.WriteLine(num);

        }
    }
}
