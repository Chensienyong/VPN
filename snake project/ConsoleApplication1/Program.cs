using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate
                {

                    while (i < 100)
                    {
                        i++;
                        if (i > 90) i = 0;

                        Console.WriteLine(i);
                    }
                }));
            Thread t2 = new Thread(new ThreadStart(delegate
                {
                }));
            t1.Start();
            Console.ReadKey(true);
            t1.Abort();
            Console.ReadLine();
        }
    }
}
