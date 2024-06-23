using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCoding1
{
class Program
{
    static void Main(string[] args)
    {
        var sentence = @"From this Basic course you are aware of very basic concepts about python programming language. We have 7+ years in python programming. Starts With very basic level. If you even don't have any programming knowledge that will be fine. You are able to learn every concept by an example.
Today python has a grate demand in industry.So if you learn this language it will help you to get your dream job also!Python is a very easy to learn and powerful language.The size of the code is too small.If you want to build a simple Java or C program of Hello World";

        string output=StringUtility.Summary(sentence,90);
        Console.WriteLine(output);
    }


}
}
