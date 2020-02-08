using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






public class ary
{

   public static void Delta(int[,] avg)
   {
      
       for (int i = 0; i <avg.Length; i++)
       {
            for (int j = 0; j < avg.Length; j++)
            {
                Console.WriteLine(avg[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }
       public static void Main(String[ ] args)
   {
       int[,] avg1 = { { 2, 3, 4 }, { 3, 4, 5 }, { 1, 9, 6 } };
       Delta(avg1);
       Console.ReadKey();
   }
}
