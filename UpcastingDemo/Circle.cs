using System;

namespace UpcastingDemo
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }
}