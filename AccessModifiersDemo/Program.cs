using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1=new Person();
            user1.SetBirthDate(new DateTime(1970, 06, 15));
            Console.WriteLine(user1.GetBirthDate());

            user1.Name = "John";
        }
    }
}
