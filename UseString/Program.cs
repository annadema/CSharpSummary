namespace UseString;

/**
 * fdfd
 * fdkfkld
 * fdkl
 */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a few numbers (eg 1-2-3-4): ");
        var input = Console.ReadLine();
        var numbers = new List<int>();

        foreach (var number in input.Split('-'))
            numbers.Add(Convert.ToInt32(number));


        var message = StringUtility.IsConsecutiveList(numbers) ? "Consecutive" : "Not Consecutive";

        Console.WriteLine(message);
    }

   

}