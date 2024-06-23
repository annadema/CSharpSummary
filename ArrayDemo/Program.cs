using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayDemo;
class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 200;
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
        var flags = new bool[3];
        flags[0] = true;
        foreach (var flag in flags)
        {
            Console.WriteLine(flag);
        }
        var names=new string[3] {"Anna","Mistral","Lorenzo"};
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        //index operator
        //per accedere all'ultimo elemento
        //alternativa a [numbers.Length-1]
        //second item from the end [^2]

        numbers[numbers.Length-1] = 99;
        int last = numbers[^1];
        Console.WriteLine(last);
        Console.WriteLine(numbers[^2]);


    }
}