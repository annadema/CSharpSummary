using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilderDemo
{
class Program
{
    static void Main(string[] args)
    {
        var header=new StringBuilder();
        var password=new StringBuilder();
        header.Append('-', 30)
            .AppendLine()
            .Append(' ', 12)
            .Append("HEADER")
            .Append(' ', 12)
            .AppendLine()
            .Append('-', 30)
            .Replace('-', '*');


        Console.WriteLine(header);


        password.Append("password= ");
        
            

        var random=new Random();
        for (int i = 0; i < 10; i++)
        {
            password.Append((char)random.Next(97, 122));
        }
        Console.WriteLine(password);

    }
}
}
