using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers=new List<int>() {1,2,3,4,5};
            var numbers2 = new List<int>() {5,100, 200, 300,5};
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            numbers.Add(0);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Count:" + numbers.Count);
            numbers.AddRange(numbers2);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Count:" + numbers.Count);

            Console.WriteLine("index of 5 is " + numbers.IndexOf(5));
            Console.WriteLine("last index of 5 is " + numbers.LastIndexOf(5));
            Console.WriteLine("Count:" + numbers.Count);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 5)
            //        numbers.Remove(numbers[i]);
            //}

            //Console.WriteLine("Count:" + numbers.Count);
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            numbers.RemoveAll(item=>item==5);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            numbers.Clear();
            Console.WriteLine("Count:" + numbers.Count);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
