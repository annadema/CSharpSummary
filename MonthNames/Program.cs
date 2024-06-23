using System.Globalization;


namespace MonthNames
{
    internal class Program
    {
        /// <summary>
        /// First, you create a new instance of the CultureInfo class (from the System.Globalization
        /// namespace), passing en as a parameter, to later get the names of months in English.
        /// Then, you declare
        /// a new single-dimensional array and initialize it with default values.
        /// It contains 12 elements to store  the names of all the months in a year.
        /// Then, the for loop is used to iterate through the numbers of all  months – that is, from 1 to 12.
        /// For each of them, a DateTime instance representing the first day in a
        /// particular month from the current year is created.
        /// The name of the month is obtained by calling the ToString method on the DateTime instance, passing
        /// the proper format of the date (MMMM), as well as specifying the culture.Then, the name is stored in the
        /// array using the [] operator and an index of the element.
        /// </summary>
        static void Main(string[] args)
        {
            CultureInfo culture = new("it");
            string[] months = new string[12];
            for (int month = 1; month <=12; month++)
            {
                DateTime firstDay = new(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM", culture);
                
                months[month-1] = name;
            }

            foreach (var m in months)
            {
                Console.WriteLine(m);
            }
        }
    }
}
