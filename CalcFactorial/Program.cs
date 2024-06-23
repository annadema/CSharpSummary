namespace CalcFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factorial = 1;

            Console.Write("Enter a number to calculate the factorial: ");

            var number = Convert.ToInt32(Console.ReadLine());
            var numberTemp = number;
            while (true)
            {
                if (number == 1)
                {
                    break;
                }
                else
                {
                    factorial = factorial * number;

                    number--;
                    continue;
                }
            }
            Console.WriteLine("{0}! =  {1}", numberTemp, factorial);
        }
    }
}
