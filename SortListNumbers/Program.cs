using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers=new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("{0} already entered",number);
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
           
        }
    }
}
