using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace Console_Snake
{
    class getdata
    {
        protected string[] setting
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
        public void tds()
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
        protected int hiscore()
        {
            if (new FileInfo("score.dat").Exists)
                return int.Parse(File.ReadAllText("score.dat"));
            else
                return 0;
        }
    }
}
