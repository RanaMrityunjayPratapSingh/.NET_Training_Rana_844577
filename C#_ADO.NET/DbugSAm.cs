using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbugSAm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 9;b = 4;
            Mul(a, b);

            for (int i=1;i<=5;i++)
            {
                var res = 5 + i;
                Console.WriteLine("result is = {0}",res);
            }
        }

        public static double Mul(int a,int b)
        {
            var p = a * b;
            return p;
        }
    }
}
