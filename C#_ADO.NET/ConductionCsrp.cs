using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConductionCsrp
{
    class Program
    {
        static void Main(string[] args)
        {

            // if else

            int a = 20;
            if (a > 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (a < 10)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }



            // Switch Case
            int b = 3;
            switch(b)
            {
                case 1:
            {
                Console.WriteLine("Hello To All");
                break;
            }
                case 2:
                    {
                        Console.WriteLine("No Hello");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Hello Nothing");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nothing");
                        break;
                    }

        }
            // Loop
            Console.WriteLine("Enter the number");
            int ac=0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("{0} * {1} = {2}",num, i, num * i);

            }
            //Do while loop
            int g = 10;
            do
            {
                Console.WriteLine("{0} is less then 100", g);
                g = g + 10;
            }
            while (g < 100);



            // while loop
            int n = 10;
            while (n > 100)
            {
                Console.WriteLine("{0} is less then 100",n);
                n = n + 10;
            }


            //factorial prog

            int fact, fn;
            fact = 1;
            Console.WriteLine("Enter number to find factorial");
            fn = int.Parse(Console.ReadLine());
            for (int j = 1; j <= fn; j++)
                fact = fact * j;
            Console.WriteLine("The factorial of {0} = {1}",fn, fact);
            Console.ReadKey  ();
    }
        }
    }

