using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PenambahPengurang
{
    class Program
    {
        public void Incrementer()
        {
            for (int i = 0; i < 50; i++)
            {
                System.Console.WriteLine("Penambah: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public void Decrementer()
        {
            for (int i = 50; i >= 0; i--)
            {
                System.Console.WriteLine("Pengurang: {0}", i);
                Thread.Sleep(1000);

                if (i == 25)
                {
                    Thread.CurrentThread.Abort();
                }
            }
        }

        public void DoTest()
        {
            Thread t1 = new Thread(new ThreadStart(Incrementer));
            Thread t2 = new Thread(new ThreadStart(Decrementer));

            t1.Start();
            t2.Start();
        }

        static void Main()
        {
            Program t = new Program();
            Console.WriteLine("Start");
            t.DoTest();
            Console.ReadKey();
        }
    }
}
