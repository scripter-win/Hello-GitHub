using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleCSharp
{
    class  Program
    {
        static int c = 1;
        static int k = 1;
        static int x = 0;
        static int y = 0;

        static void Main(string[] args)
        {
                long  k = 0;
                while (!(x == 1 && y == 1))
                {
                    k++;
                    c = 1;
                    k = 1;
                    x = 1;
                    y = 1;
                    Thread a = new Thread(call);
                    Thread b = new Thread(call2);
                    Thread cc = new Thread(call);
                    a.Start();
                    b.Start();
                cc.Start();
                a.Join();
                    b.Join();
                cc.Join();
                Console.WriteLine(x);
                    Console.WriteLine(y);
                }
            Console.WriteLine(k+"：次");
            Console.Read();
        }

        static void call()
        {
            c = 2;
            x = k;
        }
        static void call2()
        {
            k = 2;
            y = c;
        }
    }
}
