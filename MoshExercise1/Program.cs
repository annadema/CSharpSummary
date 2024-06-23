namespace MoshExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1
            Console.WriteLine("**********Exercise1*********");
            Console.WriteLine("Enter a number betweeen 1 and 10");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("valid");
            else
            {
                Console.WriteLine("invalid");
            }

            //Exercise2
            Console.WriteLine("**********Exercise2*********");
            Console.WriteLine("Write first number");
            var number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write second number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);

            //Exercise3
            Console.WriteLine("**********Exercise3*********");
            Console.WriteLine("Image width:");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Image height:");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);

            //Exercise4
            Console.WriteLine("**********Exercise4*********");
            Console.WriteLine("Write speed limit:");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write speed car");
            var speedCar = Convert.ToInt32(Console.ReadLine());

            var demeritPoints = 0;
            var stepDemerit = 5;

            if (speedCar < speedLimit)
                Console.WriteLine("OK");
            else
            {
                demeritPoints = ((speedCar - speedLimit) / stepDemerit);
                Console.WriteLine("I punti di demerito sono: " + demeritPoints);
                if (demeritPoints >= 12)
                    Console.WriteLine("Patente sospesa");

            }

        }


    }
}
