using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace MoshDateAndTime
{ 
    class Program
    {
        static void Main(string[] args)
        {

            var sentence = "This is going to be a  really really really really really really really long text.";
            Console.WriteLine(StringUtility.SummerizeText(sentence,30));
            

        }


    }
}
