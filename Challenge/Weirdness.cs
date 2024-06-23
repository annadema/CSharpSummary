using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge;

public class Weirdness
{
    public static void Check(int n)
    {
        if (n >= 1 && n <= 100)
        {
            if (((n % 2) != 0) || (n >= 6 && n <= 20))
                Console.WriteLine("Weird");
            else
                Console.WriteLine("Not Weird");
        }
        else
            Console.WriteLine("Weird");
    }
}