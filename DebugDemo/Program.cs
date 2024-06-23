using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int> {1, 2,3,4,5,6};

        var smallests = GetSmallests(numbers, 3);

        foreach (var number in smallests)
        {
            Console.WriteLine(number);
        }
    }

    public static List<int> GetSmallests(List<int> numbers, int count)
    {
        if(count > numbers.Count)
            throw new ArgumentOutOfRangeException(nameof(count),"Count must be between 1 and the number of numbers");
        var buffer = new List<int>(numbers);
        var smallests = new List<int>();

        while (smallests.Count < count)
        {
            var min = GetSmallest(buffer);
            smallests.Add(min);
            buffer.Remove(min);
        }
        return smallests;
    }

    public static int GetSmallest(List<int> smallests)
    {
        var min = smallests[0];
        for (var i = 1; i < smallests.Count; i++)
        {
            if (smallests[i] < min)
                min = smallests[i];
        }
        return min;
    }

}