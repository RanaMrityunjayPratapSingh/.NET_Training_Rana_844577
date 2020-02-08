using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkToObjectProg
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] emp = new string[7] { "Jef", "Rech", "Andre", "Mthu", "James", "Matrin" ,"Astrom"};

            var k = from e in emp
                    where e.StartsWith("J")
                    select e;

            foreach(string e in k)
            {
                Console.WriteLine("EmpName starts with J : {0}",e);
            }

            var c = emp.Where(s => s.Contains("A"));

            foreach (string e in c)
            {
                Console.WriteLine("EmpName starts with A : {0}", e);
            }

            Console.WriteLine("*****************************************");
            List<string> fruits = new List<string>() { "Apple",
            "Orange","Grapes","Pineapple","Banana","Watermelon"};
            var fr = from f in fruits
                     where f.Contains("P")
                     select f;
            foreach (string f in fr)
            {

                Console.WriteLine("Fruit with letter P : {0}",f);
            }
            var Fl = from fs in fruits
                     where fs.Length > 6
                     select fs;
            Console.WriteLine("*****************************************");

            foreach (string fs in Fl)
            {

                Console.WriteLine("Large name fruit : {0}", fs);
            }

            Console.WriteLine("*****************************************");

            var Fs = fruits.Where(frt => frt.Length<=6);

            foreach (string frt in Fs)
            {
                Console.WriteLine("Smaller name fruit  : {0}", frt);
            }

            Console.WriteLine("*****************************************");
            int[] marks = new int[5] {98, 86, 89 ,94, 93};
            var Hm = from m in marks
                     where m > 90
                     select m;

            foreach (var m in Hm)
            {

                Console.WriteLine("Large name fruit : {0}", m);
            }
            Console.WriteLine("*****************************************");
            
            var Io = from m in marks
                     orderby m descending
                     select m;
            foreach (var m in Io)
            {

                Console.WriteLine("Decending marks are : {0}", m);
            }

            Console.WriteLine("*****************************************");
            var As = marks.OrderBy(m=>m);

            foreach (var m in As)
            {
                Console.WriteLine("Assending order marks are  : {0}", m);
            }



            Console.ReadLine();
        }
    }
}
