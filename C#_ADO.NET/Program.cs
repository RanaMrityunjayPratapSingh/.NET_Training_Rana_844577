using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{


    //    public class Cal
    //    {
    //        public static int add(int a, int b)
    //        {
    //            return a + b;
    //        }
    //        public static float add(float a, float b)
    //        {
    //            return a + b;
    //        }
    //    }
    //    public class TestMemberOverloading
    //    {
    //        public static void Main()
    //        {
    //            Console.WriteLine(Cal.add(12, 23));
    //            Console.WriteLine(Cal.add(12.4f, 21.3f));
    //        }
    //    }
    //}




    public class Prog
    {

        public static void x(int a, int b)
        {
            Console.WriteLine("Sum of Two numbers are {0} and {1} is {3}", a, b, a + b);
        }

        public static void x(int a, int b, int c)
        {
            Console.WriteLine("Sum of three numbers a={0} b={1} c={2} is : ", a, b, c, a + b + c);
        }

    }
    public class Derails
    {

        static void Main(string[] args)
        {

            //Prog obj = new Prog();
            Prog.x(22, 22);
            Prog.x(22, 22, 22);

            Console.ReadLine();
        }

    }
}
