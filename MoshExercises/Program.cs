namespace MoshExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Prova();
        }

        public static void Exercise1()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0)
                {
                    count++;
                    Console.Write(i + " ");
                }
            Console.WriteLine();
            Console.WriteLine("numbers divisible for 3 are: " + count);
        }

        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {

                Console.Write("Enter a number or write ok to exit: ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
                continue;

            }
            Console.WriteLine("the sum is: " + sum);
        }

   
        public static void Exercise4()
        {

        }

        public static void Exercise5()
        {
            Console.WriteLine("Input a series of numbers separated by comma, then click Enter");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = 0;
            foreach (string t in numbers)
            {
                if (Convert.ToInt32(t) >= max)
                    max = Convert.ToInt32(t);
            }
            Console.WriteLine("max of {0} is {1}",input,max);
        }

        public static void Prova()
        {

            for (var i = 1; i < 20; i++)
                Console.Write(string.Format("site:s{0}.bitdownload.ir OR ", i));
            Console.WriteLine("");
        }
    }
}
