namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime? date = null;
            DateTime date2 =date?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);      //11/04/2018 00:00:00

        }
    }
}
