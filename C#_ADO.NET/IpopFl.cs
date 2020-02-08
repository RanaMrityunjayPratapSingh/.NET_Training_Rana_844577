using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace IpopFl
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> a = new Queue<string>();
            a.Enqueue("John");
            a.Enqueue("Rancho");
            a.Enqueue("Arnold");
            a.Enqueue("Yakub");
            foreach(var z in a)
            {
                Console.WriteLine("The implimaentation of Queue is ",z);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Stack<string> b = new Stack<string>();
            b.Push("John");
            b.Push("Rancho");
            b.Push("Arnold");
            b.Push("Yakub");

            foreach (var c in a)
            {
                Console.WriteLine("The implimentation of Stack " ,c);
            }
            Console.WriteLine("");
            b.Peek();
            b.Pop();
            foreach (var d in a)
            {
                Console.WriteLine(d);
            }

            Console.ReadKey();
        }
    }
}
            