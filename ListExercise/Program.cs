using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *ask user to supply a list of commas separated numbers (e.g 5, 1, 9, 2, 10).
 * If list is empty or includes less than 5 numbers,
 * display "Invalid List" and ask user to re-try;
 * otherwise, display the 3 smallest numbers in the list.
 *
 */

namespace Example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("enter list of number comma separated ");
            var input= Console.ReadLine();
            var numbers = input.Split(',');



        }
    }
}
