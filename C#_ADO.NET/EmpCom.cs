using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpCom;

namespace EmpApp
{
    public class Prg
    {
        static void Main(string[] args)
        {
            Employee z = new Employee()
            {
                EmpId = 10,
                EmpName = "Jeffrey",
                Depart = "Physics"
            };
            z.ShowData();

            var sal = z.GetSal(30, 800.00);
            var inc = z.GetInc(sal);

            var tsal = sal = inc;
            Console.WriteLine("Salary: {0}, incentive:{1}, Total Salary:{2}",sal, inc,tsal);
            Console.ReadKey();
        }
    }
}
