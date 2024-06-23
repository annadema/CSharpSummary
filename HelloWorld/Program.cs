using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float prova = 2.7f;
            decimal prova1 = 3.4m;

            checked
            {
                byte number = 255;
                Console.WriteLine(number);
                //number++;
                number--;
                Console.WriteLine(number);

            }
            int a = 5;
            {
                int b = 6;
                {
                    int c = 4;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
            }




        }
    }
}
