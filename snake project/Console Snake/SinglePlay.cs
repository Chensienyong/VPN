using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Console_Snake
{
    class SinglePlay:getdata
    {
        public SinglePlay()
        {
            Snake.speed = 200;
            Snake.through = true;
            if (setting != null)
            {
                if (setting[1] == "0")
                    Snake.through = false;
                else
                    Snake.through = true;
                int ss = int.Parse(setting[0]) * 10;
                Snake.speed = 250 - ss;
            }
            border a = new border();
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake(40,10);
            
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(40, 26);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hi-Score = " + hiscore());
            tds();
            //Console.ReadKey(true);
            snake1.t2.Start();
            Snake.t1.Start();
            Snake.t3.Start();
            while (!Snake.aborting)
            {
            }
            Console.SetCursorPosition(20, 26);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GAME OVER!!!");
            snake1.t2.Abort();
            Snake.t3.Abort();

            Snake.t1.Abort();
            int hi_score = hiscore();
            if (snake1.score > hi_score)
            {
                Console.SetCursorPosition(20, 27);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hi-Score");
                File.WriteAllText("score.dat", (snake1.score).ToString());
                Console.SetCursorPosition(40, 26);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Hi-Score = " + hiscore());
            }
            Console.ReadKey();
        }
    }
}
