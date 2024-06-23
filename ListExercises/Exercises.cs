using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercises
{
    class Exercises
    {
        public static void Ex1()
        {
            var friendsName = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or Enter to exit");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                friendsName.Add(input);
            }
            if (friendsName.Count == 1)
                Console.WriteLine("{0} likes your post", friendsName[0]);
            else if (friendsName.Count == 2)
                Console.WriteLine("{0} and {1} like your post", friendsName[0], friendsName[1]);
            else if (friendsName.Count > 2)
                Console.WriteLine("{0}, {1} and other {2} like your post", friendsName[0], friendsName[1],
                    (friendsName.Count - 2));
            else
                Console.WriteLine();
        }

        public static void Ex2()
        {
            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();
            var reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[input.Length - i - 1] = input[i];
            }
            var reversedString = new string(reversed);
            Console.WriteLine("reversed name is {0}",reversedString);
        }

        public static void Ex3()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number:");
                var input = Convert.ToInt32((Console.ReadLine()));
                if (numbers.Contains(input))
                    Console.WriteLine("number already entered. Retry");
                else
                    numbers.Add(input);

            }
            numbers.Sort();
            Console.WriteLine("the list of numbers sorted is:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        public static void Ex4()
        {
            var numbers = new List<int>();

            while (true)
            {

                Console.WriteLine("Enter a number or type 'quit' to exit");
                var input = Console.ReadLine();

                if (string.Equals(input.ToLower(), "quit"))
                    break;
                else if (!numbers.Contains(Convert.ToInt32((input))))
                    numbers.Add(Convert.ToInt32((input)));
            }
            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void Ex5()
        {
            var numberList = new List<int>();
            while (true)
            {
                Console.WriteLine("supply a list of comma separated numbers ");
                var input = Console.ReadLine();
                var numbers = input.Split(',');
                if (numbers.Length == 0 || numbers.Length < 5)
                {
                    Console.WriteLine("Invalid List, Please retry");
                    continue;
                }
                else
                {
                    foreach (var num in numbers)
                    {
                        if(!numberList.Contains(Convert.ToInt32(num)))
                        numberList.Add(Convert.ToInt32(num));
                    }
                    numberList.Sort();
                    break;
                }

            }
            Console.WriteLine("the three smallest numbers in the list are {0}, {1} and {2}",numberList[0], numberList[1], numberList[2]);
        

    }
    }
}
