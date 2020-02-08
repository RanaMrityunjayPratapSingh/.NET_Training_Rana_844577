using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fstprog
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bb = 255;
            short s = 99;
            int n = 98;
            long l = 76623;
            float f = 23.45f;
            double d = 76.98;
            decimal m = 999.99m;
            Console.WriteLine("Values of bb={0}, s={1}, n={2}, l={3}, f={4}, d={5}, m={6}", bb, s, n, l, f, d, m);

            DateTime dt = DateTime.Now;
            Console.WriteLine("The current Date is:  {0}", dt);
            Console.WriteLine("The current Short  date is: {0}", dt.ToShortDateString());
            Console.WriteLine("The current Long  date is: {0}", dt.ToLongDateString());
            Console.WriteLine("The current Short  date is: {0}", dt.ToShortTimeString());
            Console.WriteLine("The current Short  date is: {0}", dt.ToLongTimeString());


            int a, b;
            a = 50;
            b = 30;
            Add(a, b);
            Sub(a, b);
            double result = Mul(a, b);
            Console.WriteLine("Multiplication of {0} and {1} = {2}", a, b, result);
            Console.ReadKey();

        }

        public static void Add(int a, int b)
        {
            double c = a + b;
            Console.WriteLine("Sum of {0} and {1} = {2}", a, b, c);
        }
        public static void Sub(int a, int b)
        {
            double c = a - b;
            Console.WriteLine("Difference of {0} and {1} = {2}", a, b, c);
        }
        public static double Mul(int a, int b)
        {
            double c = a * b;
            return c;

        }
    }
}
