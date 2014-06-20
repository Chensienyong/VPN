using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Console_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake();
            Snake.speed = 100;
            Snake snake2 = new Snake(50,2,2,ConsoleColor.Red);
            Snake.t3.Start();
            Console.ReadKey(true);
            snake1.t2.Start();
            Thread.Sleep(26);
            snake2.t2.Start();
            Snake.t1.Start();
            Console.ReadKey();    
        }
    }
}
