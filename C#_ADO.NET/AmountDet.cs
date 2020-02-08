using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankComponent;

namespace AmountDet
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount z = new SavingAccount();
            
             
        //z.Detail();
            var am = z.GetSimIn(1000, 10, 2);

            var y = z.Total(1000,am);
        Console.WriteLine("Simple intrest is : {0}", am);
        Console.WriteLine("Total money : {0}", y);
        }
    }
}
