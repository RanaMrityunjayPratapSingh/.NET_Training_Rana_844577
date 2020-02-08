using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ADONETCONSOLE
{
    class Program
    {
        void greater(int x, int y, int q)
        {
            
            if (x > y && x > q)
            {
                Console.WriteLine("X is greater {x}", x);

            }
            else if (x > y && x < q)
            {
                Console.WriteLine("q is greater {0}", q);

            }
            else
            {
                Console.WriteLine("y is greater {0}", y);
            }
        }


        static void Main(string[] args)
        {

            int x;
            int y;
            int q;
            int[] a = new int[] { 1, 23, 4, 5, 6, 8, 76, 5, 453, 232, 34, 566, 43, 45, 3 };



            var b = from z in a
                    where z % 2 == 0
                    select z;
            foreach(var z in b)
            {
                Console.WriteLine("even Numbers are = {0}",z);
            }
            Program obj = new Program();
            obj.greater(10,30,20);


            Console.ReadLine();
        }
    }
    }

