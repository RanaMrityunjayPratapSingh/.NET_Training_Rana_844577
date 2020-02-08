using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emum
{
    class Program
    {




        // Enumration 

        enum Depart
        {
            Physics = 10,
            Chemistry = 12,
            Maths = 15,
            Bio = 18,
        };
        enum Color
        {
            Red = 90,Green,Blue,Yellow,
            
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Department Id of Physics : {0}", (int)Depart.Physics);
            Console.WriteLine("Department Id of Che : {0}", (int)Depart.Chemistry);
            Console.WriteLine("Department Id of Maths : {0}", (int)Depart.Maths);
            Console.WriteLine("Department Id of Bio : {0}", (int)Depart.Bio);


            Console.WriteLine("Department Id of REd : {0}", (int)Color.Red);
            Console.WriteLine("Department Id of Green : {0}", (int)Color.Green);
            Console.WriteLine("Department Id of Blue : {0}", (int)Color.Blue);
            Console.WriteLine("Department Id of yellow : {0}", (int)Color.Yellow);
            Console.ReadKey();
        }

        
    }
}
