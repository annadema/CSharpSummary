using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Exercise1: 
Write a program and continuously ask the user to enter different names, until the user presses Enter 
(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
");
           Exercises.Ex1();
            Console.WriteLine(@"Exercise2:
Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
Display the reversed name on the console.
");
           Exercises.Ex2();
           Console.WriteLine(@"Exercise3:
Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display
an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them
and display the result on the console.
");
           Exercises.Ex3();
            Console.WriteLine(@"Exercise4:
Write a program and ask the user to continuously enter a number or type ""Quit"" to exit. The list of numbers may 
include duplicates. Display the unique numbers that the user has entered.
");
            Exercises.Ex4();
            Console.WriteLine(@"Exercise5:
Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
empty or includes less than 5 numbers, display ""Invalid"" List and ask the user to re-try; otherwise, display 
the 3 smallest numbers in the list.
");
            Exercises.Ex5();
        }
    }
}
