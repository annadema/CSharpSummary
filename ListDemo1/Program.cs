using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name");
                string name= Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    break;
                names.Add(name);
            }

            switch (names.Count)
            {
                case 0: break;
                case 1: Console.WriteLine("{0} likes your post", names[0]);
                    break;
                case 2: Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                    break;
                default: Console.WriteLine("{0} and {1} and other {2} like your post", names[0], names[1], names.Count-2);
                    break;
            }


        }





    }


}




