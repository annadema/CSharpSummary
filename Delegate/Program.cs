using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor=new PhotoProcessor();
            var filters=new PhotoFilters();

            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

            Action<Photo> filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEye;
            
            processor.Process("img.jpg",filterHandler);
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("remove red eye");
        }
    }
}
