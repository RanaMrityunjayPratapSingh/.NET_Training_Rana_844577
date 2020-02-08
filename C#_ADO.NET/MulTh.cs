using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MulTh
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread is on the way");

            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("{0} is running now with Id {1}", t.Name, t.ManagedThreadId);


            //Meth();
            //Meth1();
            //Meth2();

            Thread t1 = new Thread(new ThreadStart(Meth));
            Thread t2 = new Thread(Meth1);
            Thread t3 = new Thread(Meth2);

            t1.Start();
            t2.Start();
            t3.Start();

            Thread tp = new Thread(new ParameterizedThreadStart(Test));

            tp.Start(100);

            t1.Join();t2.Join();t3.Join();tp.Join();// Join() method is responsible for preventing the main thread to exit
            //from fray unless all child treads have completed with this task

                

            Console.WriteLine("Main thread is exited");
                
            Console.ReadKey();
        }


        public static void Meth()
        {
            Console.WriteLine("Thread is started");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method : {0}", i);

            }
        }

        public static void Meth1()
        {
            Console.WriteLine("Method 1  is started");

            for (int i = 1; i <= 50; i++)
            {
                if (i == 2)
                {
                    Thread.Sleep(500);
                }
                Console.WriteLine("Method1 : {0}", i);
            }
        }

        public static void Meth2()
        {
            Console.WriteLine("Method 2 is started");
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Method2 : {0}", i);
                if (i == 25)
                {
                    
                }
            }

        }

        public static void Test(object max)
        {
            int j = Convert.ToInt32(max);

            for (int i = 1; i <= j; i++)
            {
                Console.WriteLine("Test : {0}", i);
            }

        }

      

    }
}

