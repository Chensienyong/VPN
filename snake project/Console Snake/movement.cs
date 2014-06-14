using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Console_Snake
{
   
    class movement:eats
    {
        protected byte num=1;
        static protected byte[] snakehead = new byte[2];//1=up 2=down 3=left 4= right
        public movement()
        {
            snakehead[0] = 1;
            snakehead[1] = 1;
        }
        protected void head(ConsoleKeyInfo i)
        {
            {
                if (i.Key == ConsoleKey.UpArrow && snakehead[0] != 2)
                    snakehead[0]=1;
                else if (i.Key == ConsoleKey.DownArrow && snakehead[0] != 1)
                    snakehead[0]=2;
                else if (i.Key == ConsoleKey.LeftArrow && snakehead[0] != 4)
                    snakehead[0]=3;
                else if (i.Key == ConsoleKey.RightArrow && snakehead[0] != 3)
                    snakehead[0]=4;
                else if (i.Key == ConsoleKey.W && snakehead[1] != 2)
                    snakehead[1] = 1;
                else if (i.Key == ConsoleKey.S && snakehead[1] != 1)
                    snakehead[1] = 2;
                else if (i.Key == ConsoleKey.A && snakehead[1] != 4)
                    snakehead[1] = 3;
                else if (i.Key == ConsoleKey.D && snakehead[1] != 3)
                    snakehead[1] = 4;
            }
        }
        
    }
}
