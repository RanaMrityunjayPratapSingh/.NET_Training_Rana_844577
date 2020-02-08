using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSampleEntityFramworkDBFst
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeEFDBEntities Context = new EmployeeEFDBEntities();

            //var Emp = new Employee()
            //{
            //    EmpID = 1,
            //    Name = "Rancho",
            //    Salary = 3500,
            //    SSN = 234567,
            //    DepID = 3                    
            //};
            //Context.Employees.Add(Emp);


            //var Emp12 = new Employee()
            //{
            //    EmpID = 5,
            //    Name = "James",
            //    Salary = 3800,
            //    SSN = 34567,
            //    DepID = 2
            //};
            //Context.Employees.Add(Emp12);


            LinkToEntity();

            ModifyEmp();

            DeleteEmployee();


        }
            public static void LinkToEntity() {

            EmployeeEFDBEntities Context = new EmployeeEFDBEntities();

            var Emp21 = Context.Employees;
            var emplist = from Employee in Emp21
                          orderby Employee.EmpID
                          select Emp21;
            foreach (var Employee in Emp21)
            {
                Console.WriteLine("EmpID: {0}, Name: {1}, salary: {2}, SSN: {3} ", Employee.EmpID, Employee.Name, Employee.Salary, Employee.SSN);

            }
        }

        public static void ModifyEmp()
        {
            EmployeeEFDBEntities Context = new EmployeeEFDBEntities();
            var Emp21 = Context.Employees;
            var emplist = from Employee in Emp21
                          orderby Employee.EmpID
                          select Emp21;
            foreach (var Employee in Emp21)
            {
                if (Employee.EmpID == 1)
                    Employee.Name = "Mathew";
            }
            Context.SaveChanges();
        }




        public static void DeleteEmployee()
        {
            EmployeeEFDBEntities Context = new EmployeeEFDBEntities();
            var Emp21 = Context.Employees;


            var e = new Employee { EmpID = 4 };
            Emp21.Attach(e);
            Emp21.Remove(e);



        }

    }



