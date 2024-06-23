using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesFile
{
    class Exercises
    {
        /// <summary>
        /// Write a program that reads a text file and displays the number of words.
        /// write only name of the file
        /// file must be in directory
        /// bin\Debug\net8.0
        /// 
        /// </summary>
        public static void Ex1()
        {
            string input = String.Empty;
            Console.WriteLine("write path of the file to count word");
             input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var path = Path.GetFullPath(input);

                var text = File.ReadAllText(path);

                Console.WriteLine(CountWords(text));
            }
        }

        /// <summary>
        /// Write a program that reads a text file and displays the longest word in the file.
        /// </summary>
        public static void Ex2()
        {
            Console.WriteLine("write path of the file to count word");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var path = Path.GetFullPath(input);

                var text = File.ReadAllText(path);

                Console.WriteLine(FindLongestWord(text));

            }
        }

        private static string FindLongestWord(string input)
        {
            int max = 0;
            //string[] stringSeparators = new string[] { " " ,  @"\n" , @"\r" };
            var words = input.Split(new char[] { ' ','\r', '\n' }, StringSplitOptions.None);
            string temp = "";
            
            foreach (var word in words)
            {
             if (word.Length > max)
             {
                 temp = word;
                 max = word.Length;
             }   
            }

            return temp;

        }

        public static int CountWords(string input)
        {
            int number = 0;
            var words = input.Split(' ');
            return words.Length;
        }

    }
}
