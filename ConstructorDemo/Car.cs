using System;

namespace ConstructorDemo
{
    public class Car : Vehicle
    {
        public Car(string regNumber)
            :base( regNumber)
        {
            Console.WriteLine("Car initialized, {0}",regNumber);
        }
    }
}