using System;
using System.Security.Cryptography.X509Certificates;

namespace StringDemo
{
    class Program
    {
        public enum ShippingMethod
        {
            Regular=1,Registered,Express
        }
        static void Main(string[] args)
        {
            string firstName = "Anna";
            string lastName = "Dema";

            var numbers = new int[3] {1, 2, 3};
            var uniq = string.Join(" ", numbers);

            var names = new string[2] {"Anna", "Dema"};
            var tot = string.Join("\n", names);

            string path = @"C:\Users\annam\Documents\visual studio 2015\Projects\MOSH";

            String aaa = "anna";

            var method = ShippingMethod.Express;
         
            Console.WriteLine((int)method);

            var num = 3;
            Console.WriteLine((ShippingMethod)num);

            var stringa = "Regular";
            var num1 = (ShippingMethod)Enum.Parse(typeof(ShippingMethod),stringa);

            Console.WriteLine(num1);


        }
    }
}
