using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatchMio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"What do you want to do? 
Press (1) to start the stopwatch
Press (2) to stop the stopwatch
Press (3) to exit");



            var stopwatch = new StopWatch.StopWatch();

            while (true)
            {
                var input = Console.ReadKey();

//                Console.WriteLine(input.KeyChar);
                Console.WriteLine();
                switch (input.KeyChar)
                {
                    case '1':
                    {
                        stopwatch.Start();
                        break;
                    }
                    case '2':
                    {
                        stopwatch.Stop();
                        break;
                    }
                    case '3':
                    {
                        return;
                    }
                }
            }
        }
    }
}