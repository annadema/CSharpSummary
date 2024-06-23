using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books=new BookRepository().GetBooks();

            //            var cheapBooks=new List<Book>();
            //
            //            foreach (var book in books)
            //            {
            //                if(book.Price<10)
            //                    cheapBooks.Add(book);
            //            }
            /* var cheapBooks1 =
                 from b in books
                 where b.Price < 10
                 orderby b.Title
                 select b;



 //            var cheapBooks = books
 //                                .Where(b => b.Price < 10)
 //                                .OrderBy(b => b.Title)
 //                                .Select(b=>b.Title);

             foreach (var book in cheapBooks1)
             {
                 Console.WriteLine(book);   
             }*/


            var averagePrice = books.Average(b => b.Price);
            Console.WriteLine(averagePrice);  //8,598

            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(2, 3));


        }

        private static float CalculateDiscount(float price)
        {
            return 0;
        }
    }
}
