namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 10);

            Console.WriteLine($"hint {number}");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write(@"Guess the number (5 ties):");
                
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == number)
                {
                    Console.WriteLine("You win");
                    break;
                }
                else if (i == 4)
                {
                    Console.WriteLine("You lost");
                }
            }
        }
    }
}
