using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercises
{
    public class Exercises
    {
        public static void Execute1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("ci sono " + count + " numeri divisibili per 3 tra 1 e 100");
        }
        public static void Execute2()
        {
            var result = 0;
            while (true)
            {

                Console.WriteLine("Enter a number or type \"ok\" to exit");
                var input = Console.ReadLine();
                if (string.Equals(input, "ok"))
                {
                    break;
                }
                result += Convert.ToInt32(input);

            }
            Console.WriteLine("the sum of the numbers is " + result);
        }
        public static void Execute3()
        {
            Console.WriteLine("Enter a number");
            var input = Convert.ToInt32((Console.ReadLine()));
            var factorial = 1;
            for (int i = input; i > 0; i--)
            {
                factorial *= i;
                //Console.WriteLine(factorial);
            }

            Console.WriteLine(factorial);
        }
        public static void Execute4()
        {
            var random = new Random();
            var secretNumber = random.Next(1, 10);
            Console.WriteLine("secret: " + secretNumber);
            Console.WriteLine("guess the number");
            var i = 1;
            for (i = 1; i <= 4; i++)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == secretNumber)
                {
                    Console.WriteLine("You won!");
                    return;

                }

            }

                Console.WriteLine("You lost!");
        }
        public static void Execute5()
        {
            Console.WriteLine("Enter a series of numbers separated by comma");
            var input = Console.ReadLine();
            string[] nums;
            nums = input.Split(',');
            int max = 0;
            int temp = 0;
            foreach (string num in nums)
            {
                //Console.WriteLine(num);
                temp = Convert.ToInt32(num);
                if (temp >= max)
                    max = temp;

            }
            Console.WriteLine("max is " + max);
        }

    }
}
