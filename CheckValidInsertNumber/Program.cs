


namespace CheckValidInsertNumber
{
    internal class Program
    {
        /// <summary>
        /// ask user to enter a number between 1 to 10. 
        ///If the user enters a valid number, display "Valid". 
        ///Otherwise, display "Invalid".
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number between 1 and 10: ");
                var number = Convert.ToInt32(Console.ReadLine());

                //solution1
                //if ((number >= 1) && (number <= 10))
                //    Console.WriteLine("Valid");
                //else
                //    Console.WriteLine("Invalid");

                //solution2
                //string message = String.Format("Number is {0}", (number >= 1 && number <= 10) ? "Valid" : "Invalid");
                //Console.WriteLine(message);

                //solution3
                Console.WriteLine((number >= 0) && (number <= 10) ? "Valid" : "Ivalid");
            }
        }
    }
}
