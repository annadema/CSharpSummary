using System;
using System.Text;

namespace MoshStringBuilder
{
    class Program 
    {
        static void Main(string[] args)
        {
            var builder=new StringBuilder();
            builder
                .Append('-', 20)
                .AppendLine()
                .Append(' ', 7)
                .Append("Header")
                .Append(' ', 7)
                .AppendLine()
                .Append('-', 20)
                .Replace('-', '+')
                .Remove(29, 6);
            var size = builder.Length;
            builder.Insert(29, new string('*', 20));
            
            Console.WriteLine(builder);
        }
    }
}
