using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesString
{
    class Exercises
    {
        /// <summary>
        ///  Write a program and ask the user to enter a few numbers separated by a hyphen. 
        ///  Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" 
        ///  or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        public static void Ex1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            var message = IsConsecutive(input) ? "Consecutive" : "Not Consecutive";

            Console.WriteLine(message);

        }
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. 
        /// If the user simply presses Enter, without supplying an input, exit immediately; 
        /// otherwise, check to see if there are duplicates. 
        /// If so, display "Duplicate" on the console.
        /// </summary>
        public static void Ex2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var input = Console.ReadLine();

            var message = IsDuplicate(input) ? "Duplicate" : "";

            Console.WriteLine(message);

        }
        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
        /// otherwise, display "Invalid Time". 
        /// If the user doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static void Ex3()
        {
            Console.WriteLine("enter a time value in the 24-hour time format, between 00:00 and 23:59");

            string input = Console.ReadLine();

            string output = isValidTime(input) ? "Ok" : "Invalid Time";

            Console.WriteLine(output);

        }
        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space.
        /// Use the words to create a variable name with PascalCase. 
        /// For example, if the user types: "number of students", display "NumberOfStudents". 
        /// Make sure that the program is not dependent on the input. 
        /// So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        /// </summary>
        public static void Ex4()
        {
            Console.WriteLine("enter a few words separated by a space");
            var input = Console.ReadLine();

            StringBuilder variableName = CreateVariableName(input);
            
            Console.WriteLine("the variable name is "+ variableName);

        }
        /// <summary>
        /// Write a program and ask the user to enter an English word.
        /// Count the number of vowels (a, e, o, u, i) in the word. 
        /// So, if the user enters "inadequate", the program should display 6 on the console.
        /// </summary>
        public static void Ex5()
        {
            Console.WriteLine("enter an English word");

            var input = Console.ReadLine();

            var numberOfWowels = CountNumberofVowels(input);

            Console.WriteLine("the number of wowels in the word {0} is {1}",input,numberOfWowels);
        }

        public static int CountNumberofVowels(string input)
        {
            int count = 0;
            var temp=input.ToLower();

            for (int i = 0; i < input.Length;i++) { 
                if (temp[i] == 'a' || temp[i] == 'e' || temp[i] == 'i' || temp[i] == 'o' || temp[i] == 'u')
                    count++;
            }
            return count;
        }

        public  static StringBuilder CreateVariableName(string input)
        {
            var words = input.Split(' ');
            var variableName= new StringBuilder();
            foreach (var word in words)
            {
                string wordTemp= word.First().ToString().ToUpper() + word.Substring(1).ToLower();
                variableName.Append(wordTemp);
            }
            
            return variableName;
        }

        public static bool isValidTime(string input)
        {
            bool isValid = false;
            if (!string.IsNullOrWhiteSpace(input))
            {
                var time = input.Split(':');
                if (time.Length == 2)
                {
                    var hour = Convert.ToInt32((time[0]));
                    var minute = Convert.ToInt32((time[1]));

                    if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                        isValid = true;
                }
             }
            return isValid;
        }

        public static bool IsConsecutive(string input)
        {
            var numbers = input.Split('-');
            var inputList = new List<int>();
            foreach (var num in numbers)
            {
                inputList.Add(Convert.ToInt32(num));
            }

            inputList.Sort();

            var isConsecutive = true;

            for (int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i] != inputList[i - 1] + 1)

                    isConsecutive = false;
                break;
            }
            return isConsecutive;
        }



        public static bool IsDuplicate(string input)
        {
            var isDuplicate = false;
            if (!string.IsNullOrWhiteSpace(input))
            {

                var numbers = input.Split('-');
                var inputList = new List<int>();

                foreach (var num in numbers)
                {
                    if (inputList.Contains(Convert.ToInt32((num))))
                    {
                        isDuplicate = true;
                        break;
                    }

                }
            }
            return isDuplicate;

        }
    }

}
