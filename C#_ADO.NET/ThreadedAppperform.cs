using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ThreadedAppperform
{
    class Pro
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Stopwatch a = new Stopwatch();
            a.Start();
            IncrementCount1();
            IncrementCount2();
            a.Start();

            Stopwatch a1 = new Stopwatch();

            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
          
            a.Start();
            t1.Start();
            t2.Start();
            a1.Stop();


            t1.Join();
            t2.Join();

            Console.WriteLine("Total Time Elapsed afor single Threaded Application : {0}",a.ElapsedMilliseconds);

            Console.WriteLine("Total Time Elapsed for a multy Threaded Application : {0} ", a1.ElapsedMilliseconds);

            Console.WriteLine("Main thread Exited ");


        }
        public static void IncrementCount1()
        {
            long Count1 = 0;
            for (int i = 0; i < 1000; i++)
            {
                Count1++;

                Console.WriteLine("Count1 : {0}", Count1);
            }
        }

                 public static void IncrementCount2()
            {
                long Count2 = 0;
                for(int i=0;i<1000;i++)
                {
                    Count2++;

                    Console.WriteLine("count2 : {0}", Count2);
                }
            }

            }
        }
    

