using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshList
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int> { 1, 3, 5, 7 };
            var numbers = new int[4] { 9, 9, 9, 9 };
            myList.AddRange(numbers);

//            foreach (var num in myList)
//            {
//                Console.WriteLine(num);
//            }
//            Console.WriteLine("Length: " + myList.Count);

            for (int i = 0; i < myList.Count; i++)
            {

                if (myList[i] == 9)
                {
                    myList.Remove(myList[i]);
                    Console.WriteLine("iterazione "+  i + "remove: " + myList[i]);
                }

                Console.WriteLine("count: " + myList.Count);
            }

            foreach (var num in myList)
            {
                Console.WriteLine(num);
            }

        }
    }
}
