namespace ReverseInputString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            var temp = new char[name.Length];
            for (var i = 0; i < name.Length; i++)

                temp[i] = name[name.Length - i - 1];
            var reversed = new string(temp);
            Console.WriteLine(reversed);
        }
    }
}
