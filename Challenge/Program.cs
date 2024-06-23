using System;

namespace Challenge;

class Program
{
    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());

        Weirdness.Check(N);
    }
}