using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10 ; i+=1)
            //{
            //    if(i%2 ==0)
            //    Console.WriteLine(i);
            //}
            //for (int i = 10; i >0; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //var i = 1;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            while (true)
            {
                Console.Write("Type ypur name: ");
                var input = Console.ReadLine();


                //if (String.IsNullOrWhiteSpace(input))
                //{
                //    break;
                //}
                //Console.WriteLine("@Echo: "+input);

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: "+input);
                    continue;
                }
                break;
            }
        }
    }
}
