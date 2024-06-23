using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var stack=new Stack();
            int start = 1;
            int end = 10;

            for (int i = start; i <= end; i++)
                stack.Push(i);

            //stack.Clear();

            for (int i = start; i <= end; i++)
                Console.WriteLine(stack.Pop());

            //stack.Push(null);
            //Console.WriteLine(stack.Pop());

            stack.Push(4);
            stack.Clear();

        }
    }
}
