namespace NumberOfLikes
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var names = new List<string>();
        while (true)
        {
            Console.Write("Enter name or ENTER to quit: ");
            var name = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(name))
                break;
            names.Add(name);
        }

        string message="";
        switch (names.Count)
        {
            case 0:
                message=String.Format("nobody likes yout post");
                break;
            case 1:
                message = String.Format("{0} likes your post", names[0]);
                break;
            case 2:
                message = String.Format("{0} and {1} like your post", names[0], names[1]);
                break;
            default:
                message = String.Format("{0},  {1} and {2} others like your post", names[0], names[1], (names.Count - 2));
                break;
        }

        Console.WriteLine(message);        }
    }
}
