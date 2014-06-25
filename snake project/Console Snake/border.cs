using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class border
    {
        private ConsoleColor color
        {
            get 
            {
                if (Snake.through)
                    return ConsoleColor.Green;
                else
                    return ConsoleColor.Magenta;
            }
        }
        private void full()
        {
            for (int i = 0; i < 80; i++)
            {
                Console.ForegroundColor = color;
                Console.Write("#");
            }
        }
		public border()
        {
            full();
            for (int i = 0; i < 24; i++)
            {
                Console.Write("#");
                Console.SetCursorPosition(79, i + 1);
                Console.Write("#");
            }
            full();
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("Score:");
        }
    }
}
