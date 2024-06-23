 using System;

namespace ConstructorDemo
{
    public class Vehicle
    {
        private string _registrationNumber;


        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle initialized, {0}",registrationNumber);
        }
    }
}