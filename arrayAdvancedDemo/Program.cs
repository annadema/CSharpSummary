namespace arrayAdvancedDemo;

class Program
{
    static void Main(string[] args)
    {
        var vect1 = new int[2, 3]
        {
            {1, 2, 3},
            {4, 5, 6}
        };
        foreach (var num in vect1)
        {
            Console.WriteLine(num);
        }
        var vect2 = new int[2][];
        vect2[0] = new int[2] { 1, 2 };
        vect2[1] = new int[5];
        foreach (var num in vect2[0])
        {
            Console.WriteLine(num);
        }
        foreach (var num in vect2[1])
        {
            Console.WriteLine(num);
        }

        var numbers1 = new int[] {1, 2, 7, 3, 2, 6};
        Console.WriteLine(numbers1.Length);
        Console.WriteLine(Array.IndexOf(numbers1,4));
        // Array.Clear(numbers1,3,3);
        foreach (var num in numbers1)
        {
            Console.WriteLine("num: " +num);
        }

        var numbers2 = new int[4];
        Array.Copy(numbers1,numbers2,3);

        foreach (var num in numbers2)
        {
            Console.WriteLine("num2: " + num);
        }

        Array.Sort(numbers1);
        foreach (var num in numbers1)
        {
            Console.WriteLine("num: " + num);
        }
        Array.Reverse(numbers1);
        foreach (var num in numbers1)
        {
            Console.WriteLine("num4: " + num);
        }
    }
}