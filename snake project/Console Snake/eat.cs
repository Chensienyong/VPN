using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Snake
{
    class eats
    {
        static protected bool eat = false;
        static protected bool foodavail = false;
        static protected int[] foodloc = new int[2];
        static protected void makanan(bool[,] loc)
        {
            Random x = new Random();
            Random y = new Random();
            bool locavailable = false;
            do
            {
                int rx = x.Next(0,79);
                int ry = y.Next(0,24);

                bool c = false;
                if (loc[rx,ry]==true)
                    {
                        c = true;
                        break;
                    }
                if (!c)
                {
                    locavailable = true;
                    Console.SetCursorPosition(rx, ry);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write((char)15);
                    foodavail = true;
                    foodloc[0] = rx;
                    foodloc[1] = ry;
                }
            } while (!locavailable);
        }
    }
}
