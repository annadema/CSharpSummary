﻿using System;

namespace UpcastingDemo
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("draw a shape");
        }
    }
}