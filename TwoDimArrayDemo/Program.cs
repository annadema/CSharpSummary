namespace TwoDimArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            int[,] results = new int[10, 10];
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i +1) * (j + 1);
                    Console.Write($"{results[i, j],6}");
                }

                
                Console.WriteLine();
            }
        }
    }
}
