namespace PointClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(2, 3);
            Console.WriteLine("{0} {1}", point.X, point.Y);
            point.Move(10, 100);
            Console.WriteLine("{0} {1}", point.X, point.Y);

            point.Move(new Point(2, 3));
            Console.WriteLine("{0} {1}", point.X, point.Y);
        }
    }
}
