using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes=new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas=new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
