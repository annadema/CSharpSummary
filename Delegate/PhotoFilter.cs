using System;

namespace Delegate
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("apply brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("apply contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("resize image");
        }
    }
}