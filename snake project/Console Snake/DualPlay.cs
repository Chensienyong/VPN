using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Console_Snake
{
    class DualPlay:getdata
    {
        public DualPlay()
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
            Snake snake1 = new Snake(50,10);
            Snake snake2 = new Snake(2, 10, 2, ConsoleColor.Red);
            //Snake.t3.Start();
            Console.SetCursorPosition(0, 0);
            tds();
            //Console.ReadKey(true);
            snake1.t2.Start();
            Thread.Sleep(75);
            snake2.t2.Start();
            Snake.t1.Start();
            Thread pausing = new Thread(new ThreadStart(delegate
            {
                bool cek1 = false;
                while (true)
                {
                    if (Snake.pause)
                    {
                        cek1 = true;
                        snake1.t2.Suspend();
                        snake2.t2.Suspend();
                        Console.SetCursorPosition(60, 26);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Pause!!!");
                    }
                    else
                    {
                        if (cek1)
                        {
                            cek1 = false;
                            Console.SetCursorPosition(60, 26);
                            Console.Write("        ");
                            tds();
                            snake1.t2.Resume();
                            Thread.Sleep(75);
                            snake2.t2.Resume();
                        }
                    }
                }
            }));
            pausing.Start();
            
            while (!Snake.aborting)
            {
            }    
                snake1.t2.Abort();
                snake2.t2.Abort();
                pausing.Abort();
                //File.WriteAllText("new.txt", (point.Count - 2).ToString());
                Snake.t1.Abort();
                bool snakea=false;
                bool snakeb=false;
                snakea = snake1.me_lose;
                snakeb = snake2.me_lose;
                foreach (var x in snake2.point)
                {
                    if (snake1.point.Last()[0] == x[0] && snake1.point.Last()[1] == x[1])
                    {
                        if (snake2.point.Last()[0] != x[0] && snake2.point.Last()[1] != x[1])
                        {
                            snakeb = true;
                            break;
                        }
                        snakea = true;
                        break;
                    }
                }
                foreach (var x in snake1.point)
                {
                    if (snake2.point.Last()[0] == x[0] && snake2.point.Last()[1] == x[1])
                    {
                        if (snake1.point.Last()[0] != x[0] && snake1.point.Last()[1] != x[1])
                        {
                            snakeb = true;
                            break;
                        }
                    }
                }
                if (snake2.point.Last()[0] == snake1.point.Last()[0] && snake2.point.Last()[1] == snake1.point.Last()[1])
                {
                    snakea = true;
                    snakeb = true;
                }
                if (snakea && snakeb)
                {

                    Console.SetCursorPosition(20, 26);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GAME OVER!!!");        
                    if (snake1.score > snake2.score)
                    {
                        Console.SetCursorPosition(20, 27);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Player1 Wins!!!");
                    }
                    else if (snake1.score < snake2.score)
                    {
                        Console.SetCursorPosition(20, 27);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Player2 Wins!!!");
                    }
                    else
                    {
                        Console.SetCursorPosition(20, 27);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Draw!!!");
                    }
                }
                else if (snakea && !snakeb)
                {

                    Console.SetCursorPosition(20, 26);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GAME OVER!!!");        
                    Console.SetCursorPosition(20, 27);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Player2 Wins!!!");
                }
                else if (!snakea && snakeb)
                {
                    Console.SetCursorPosition(20, 26);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("GAME OVER!!!");        
                    Console.SetCursorPosition(20, 27);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Player1 Wins!!!");
                }
                else if (!snakea && !snakeb)
                {
                    int counta = 0;
                    foreach (var x in snake1.point)
                    {
                        if (snake1.point.Last()[0] == x[0] && snake1.point.Last()[1] == x[1])
                        {
                            counta++;
                        }
                    }
                    if (counta > 1)
                    {

                        Console.SetCursorPosition(20, 26);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("GAME OVER!!!");        
                        Console.SetCursorPosition(20, 27);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Player2 Wins!!!");
                    }
                    else
                    {

                        Console.SetCursorPosition(20, 26);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("GAME OVER!!!");        
                        Console.SetCursorPosition(20, 27);
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Player1 Wins!!!");
                    }
                }
                Console.ReadKey();
            
            //Snake.t3.Start();
            //Console.ReadKey();    
        }
    }
}
