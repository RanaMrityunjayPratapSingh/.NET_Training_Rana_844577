using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankComponent
{
    public class SavingAccount
    {
        public double P
        {
            get;
            set;
        }
        public double R
        {
            get;
            set;
        }
        public double T
        {
            get;
            set;
        }
        public double GetSimIn(double P, double R, double T)
        {
            var s = P * R * T / 100;
            Console.WriteLine("Principle amount is : {0} ,Rate of ammount is : {1} , Time is : {2} ", P, R, T);
            //Console.WriteLine(s);
            return s;
        }
        public double Total(double P, double s)
        {
            var to = P + s;
            return to;
            //Console.WriteLine("Total amount = {0}", to);
        }
        //public void Detail()
        //{
        //    Console.WriteLine("Principle amount is : {0} ,Rate of ammount is : {1} , Time is : {2} ", P, R, T);

        //}
    }
}
