using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadlockingApp
{
    class ThreadLock
    {
        static void Main(string[] args)
        {
            ThreadLock obj = new ThreadLock();

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();

        }
        public void Display()
        {

            lock (this)
            {
                Console.WriteLine("Csharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object oriented Langugae");
            }
        }
    }
}
