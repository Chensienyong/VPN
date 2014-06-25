using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Security;
namespace Console_Snake
{
    class Program
    {
        /*static public string[] setting
        {
            get
            {
                if (new FileInfo("setting.dat").Exists)
                {
                    return File.ReadAllText("setting.dat").Split(' ');
                }
                else
                    return null;
            }
        }
        static public void tds()
        {
            for (int i = 3; i > 0; i--)
            {
                Console.SetCursorPosition(60, 26);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i);
                Thread.Sleep(900);
            }
            Console.SetCursorPosition(60, 26);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("GO!!!");
            Thread.Sleep(500);
            Console.SetCursorPosition(60, 26);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("     ");
        }
        static public int hiscore()
        {
            if (new FileInfo("score.dat").Exists)
                return int.Parse(File.ReadAllText("score.dat"));
            else
                return 0;
        }*/
        /*static public void dual_player()
        {
            border a = new border();
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake(50,10);
            Snake.speed = 200;
            Snake.through = true;
            if (setting != null)
            {
                if (setting[1] == "1")
                    Snake.through = false;
                else
                    Snake.through = true;
                int ss=int.Parse(setting[0]) * 10;
                Snake.speed = 250 - ss;
            }
            
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
        }*/
        /*static public void single_player()
        {
            border a = new border();
            Console.SetWindowSize(Console.WindowWidth, 30);
            Snake snake1 = new Snake();
            Snake.speed = 200;
            Snake.through = true;
            if (setting != null)
            {
                if (setting[1] == "1")
                    Snake.through = false;
                else
                    Snake.through = true;
                int ss = int.Parse(setting[0]) * 10;
                Snake.speed = 250 - ss;
            }
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
        }*/
        static void Main(string[] args)
        {
            switch(/*"1")//*/args[0])
            {
                case "1":
                    new SinglePlay();
                    break;
                case "2":
                    new DualPlay();
                    break;
                default:
                    break;
            }
        }
    }
}
