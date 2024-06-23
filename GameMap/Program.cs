using System.Text;
namespace GameMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map =
            {
                { 's', 's', 's', 'g', 'g', 'g', 'g', 'g' }, 
                { 's', 's', 's', 'g', 'g', 'g', 'g', 'g' }, 
                { 's', 's', 's', 's', 'b', 'b', 'b', 'b' }, 
                { 's', 's', 's', 's', 'b', 'b', 's', 's' }, 
                { 'w', 'w', 'b', 'b', 'b', 'b', 'w', 'w' }, 
                { 'w', 'w', 'b', 'b', 'b', 'b', 'w', 'w' }
            };
            Console.OutputEncoding = Encoding.UTF8;

            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    Console.ForegroundColor = GetColor(map[r, c]);
                    Console.Write(GetChar(map[r, c]) + " ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        static ConsoleColor GetColor(char terrain)
        {
            return terrain switch
            {
                'g' => ConsoleColor.Green,
                's' => ConsoleColor.Cyan,
                'w' => ConsoleColor.Blue,
                _ => ConsoleColor.Magenta
            };
        }
        static char GetChar(char terrain)
        {
            return terrain switch
            {
                'g' => '\u2622',
                's' => '\u2618',
                'w' => '\u262A',
                _ => '\u2620'
            };
        }
    }
}
