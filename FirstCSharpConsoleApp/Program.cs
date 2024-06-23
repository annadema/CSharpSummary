using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharpConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.BackgroundColor = ConsoleColor.Blue;

        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Come ti chiami?");
        string name;
        name = Console.ReadLine();
        Console.WriteLine("Buongiorno " + name);
            
        Console.ReadKey();
    }
}