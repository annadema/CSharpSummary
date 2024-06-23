using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordLenght = 10;
            var random=new Random();
            var buffer=new char[passwordLenght];
            
            for (int i = 0; i < passwordLenght; i++)
            {
                //Console.Write((char)random.Next(97,122));
                buffer[i]= (char)random.Next(97, 122);
            }
            var password = new string(buffer);
            Console.WriteLine("password= " + password);

        }
    }
}
