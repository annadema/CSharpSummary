using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise5();
        }

        public static void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name or click Enter: ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                names.Add(input);
            }

            Console.WriteLine();
            if (names.Count == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            if (names.Count == 2)
                Console.WriteLine("{0} and {1} likes your post", names[0], names[1]);
            if (names.Count > 2)
                Console.WriteLine("{0} and {1} and {2} others like your post", names[0], names[1], names.Count - 2);
        }

        public static void Exercise2()
        {

            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();

            var letters = input.ToCharArray();
            Array.Reverse(letters);
            Console.WriteLine(letters);

        }

        public static void Exercise22()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            var nameArray = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {

                nameArray[name.Length - i] = name[i - 1];

            }

            var reversed = new string(nameArray);

            Console.WriteLine(reversed);

        }

        public static void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(input))
                {
                    Console.WriteLine("Hai già inserito " + input);
                    continue;
                }
                numbers.Add(input);

            }

            numbers.Sort();
            foreach (var num in numbers)
            {
                Console.Write(num);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or type 'quit' to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                if (!numbers.Contains(Convert.ToInt32(input)))
                    numbers.Add(Convert.ToInt32(input));
                continue;

            }
            if (numbers.Count != 0)
            {
                Console.WriteLine("Unique numbers entered:");
                foreach (var num in numbers)
                {
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }

        public static void Exercise5()
        {

            var lnumbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a list of comma separated numbers: ");
                var input = Console.ReadLine();

                var numbers = input.Split(',');

                if (numbers[0] != "")
                {

                    foreach (var num in numbers)
                    {
                        lnumbers.Add(Convert.ToInt32(num));
                    }

                    if ((lnumbers.Count < 5) || (lnumbers.Count == 0))
                    {
                        Console.WriteLine("Invalid list. Please retry!");
                        continue;
                        
                    }
                    else if (lnumbers.Count == 5)
                        break;
                    else
                    {
                        foreach (var num in lnumbers)
                        {
                            Console.WriteLine(num);
                        }
                        Console.WriteLine();
                    }
                }

            }



        }

    }
}
