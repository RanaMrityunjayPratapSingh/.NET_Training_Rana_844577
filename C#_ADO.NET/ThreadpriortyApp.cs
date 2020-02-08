using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadpriortyApp
{
    class Program
    {
        public static long Count1, Count2;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Increment1);
            Thread t2 = new Thread(Increment2);
            Console.WriteLine("Ths main Thread is Started");

            t1.Start();
            t2.Start();



            t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.AboveNormal;
            t2.Priority = ThreadPriority.Highest;



            Thread.Sleep(10000);

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();


            Console.WriteLine("Count1 : {0}", Count1);
            Console.WriteLine("Count2 : {0}", Count2);

            Console.WriteLine("Ths Main Thread is exited");


        }
        public static void Increment1()
        { 
            while (true)
            {
                Count1 += 1;
            }
            Console.WriteLine("count1 : {0}", Count1);
        }


        public static void Increment2()
        {
            while (true)
            {
                Count2 += 1;
            }
            Console.WriteLine("Count2 : {0}",Count2);
        }
    }
}
