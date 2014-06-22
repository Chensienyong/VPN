using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Console_Snake
{
    class Program
    {
        /*static Thread pausing = new Thread(new ThreadStart(delegate
            {
                bool cek1 = false;
                while (true)
                {
                    if (Snake.pause)
                    {
                        cek1 = true;
                        snake1.t2.Suspend();
                        snake2.t2.Suspend();
                    }
                    else
                    {
                        if (cek1)
                        {
                            cek1 = false;
                            snake1.t2.Resume();
                            snake2.t2.Resume();
                        }
                    }
                }
            }));*/
        static public void dual_player()
        {
            border a = new border();
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake();
            Snake.speed = 200;
            Snake snake2 = new Snake(50, 2, 2, ConsoleColor.Red);
            //Snake.t3.Start();
            Console.SetCursorPosition(0, 0);
            Console.ReadKey(true);
            snake1.t2.Start();
            Thread.Sleep(Snake.speed / 4);
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
                    }
                    else
                    {
                        if (cek1)
                        {
                            cek1 = false;
                            snake1.t2.Resume();
                            Thread.Sleep(Snake.speed / 4);
                            snake2.t2.Resume();
                        }
                    }
                }
            }));
            pausing.Start();
            //Snake.t3.Start();
            //Console.ReadKey();    
        }
        static public void single_player()
        {
            border a = new border();
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake();
            Snake.speed = 200;
            Console.SetCursorPosition(0, 0);
            Console.ReadKey(true);
            snake1.t2.Start();
            Snake.t1.Start();
            Snake.t3.Start();
            //Console.ReadKey();  
        }
        static void Main(string[] args)
        {
            switch(args[0])
            {
                case "1":
                    single_player();
                    break;
                case "2":
                    dual_player();
                    break;
                default:
                    break;
            }
        }
    }
}
