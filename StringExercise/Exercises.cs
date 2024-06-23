using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosh
{
    class Exercises
    {
        public static void RunEx1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            var message = IsConsecutive(input) ? "Consecutive" : "Not Consecutive";

            Console.WriteLine(message);
        }

        public static void RunEx2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            if (IsDuplicate(input))
                Console.WriteLine("Duplicate");

        }

        public static void RunEx3()
        {
            Console.WriteLine("enter a time value in the 24-hour time format");
            var input = Console.ReadLine();
            bool isInvalidTime = string.IsNullOrWhiteSpace(input) || IsTimeInvalid(input);

            var message = isInvalidTime ? "Time invalid" : "Ok";

            Console.WriteLine(message);
        }


        public static bool IsConsecutive(string input)
        {
            var numbers = input.Split('-');
            var inputList = new List<int>();
            foreach (var num in numbers)
            {
                inputList.Add(Convert.ToInt32(num));
            }

            //inputList.Sort();

            var isConsecutive = true;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i + 1] > inputList[i])
                    isConsecutive = true;
                else
                {
                    isConsecutive = false;
                    break;
                }
            }

            for (int i = inputList.Count - 1; i > 0; i--)
            {
                if (inputList[i] >= inputList[i - 1])
                    isConsecutive = true;
                else
                {
                    isConsecutive = false;
                    break;
                }
            }

            return isConsecutive;
        }

        public static bool IsDuplicate(string input)
        {
            var numbers = new List<int>();

            var stringNumbers = input.Split('-');
            foreach (var num in stringNumbers)
            {
                var numConverted = Convert.ToInt32(num);
                if (!numbers.Contains(numConverted))
                    numbers.Add(numConverted);
                else
                    return true;
            }
            return false;

        }
        public static bool IsTimeInvalid(string input)
        {
            var isInvalidTime = false;



            var component = input.Split(':');

            if (component.Length != 2)
                isInvalidTime = true;

            var hour = Convert.ToInt32(component[0]);
            var minute = Convert.ToInt32(component[1]);

            if (!(hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59))
                isInvalidTime = true;

            return isInvalidTime;
        }
    }
}
