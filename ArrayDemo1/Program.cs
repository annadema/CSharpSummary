using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {15, 7, 9, 0, 14, 6};
            Console.WriteLine("Lenght:" + numbers.Length);
            Console.WriteLine($"Index of 9: {Array.IndexOf(numbers, 9)}");
            Console.WriteLine("Clear first part of the array:");
            Array.Clear(numbers, 0, 3);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var numbers2 = new int[numbers.Length];
            Array.Copy(numbers, numbers2, 2);

            var booleans = new[] { true, true, true, false, false, true };
            Console.WriteLine(booleans.Length);
            Array.Clear(booleans, 0, 3);
            foreach (var num in booleans)
            {
                Console.WriteLine(num);
            }

            var stringhe = new[] { "anna", "giovanni", "mario" };
            Array.Clear(stringhe, 0, stringhe.Length);
            foreach (var nome in stringhe)
            {
                Console.WriteLine("nome: {0}, ", nome);
            }

            Array.Sort(numbers);
//            foreach (var num in numbers)
//            {
//                Console.WriteLine(num );
//            }

            Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
