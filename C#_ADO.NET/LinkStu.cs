using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkStu
{ 
        public class Program
        {
        public static void Main()
        {
            List<StdDetails> StdDetailsList = new List<StdDetails>()
                {
                new  StdDetails() { StudentID = 1, FirstName = "John",LastName="Yadav",City="New Delhi"} ,
                new  StdDetails() { StudentID = 2, FirstName = "Moin",LastName="Gopal",City="Lahore"} ,
                new  StdDetails() { StudentID = 3, FirstName = "Bill",LastName="Singh",City="Ravalpindi"} ,
                new StdDetails() { StudentID = 4, FirstName = "Ram",LastName="Tiwari",City="Mumbai"} ,
                new StdDetails() { StudentID = 5, FirstName = "Ron",LastName="Lala",City="Karachi"}
                };

            List<TecDetails> TecDetailsList = new List<TecDetails>()
                {
                new  TecDetails() { TecherID = 1, FirstName = "Ohn",LastName="Dav",City="New Delhi"} ,
                new  TecDetails() { TecherID = 2, FirstName = "Min",LastName="Pal",City="Lahore"} ,
                new  TecDetails() { TecherID = 3, FirstName = "Ill",LastName="Singh",City="Ravalpindi"} ,
                new TecDetails() { TecherID = 4, FirstName = "GRam",LastName="Triveni",City="Mumbai"} ,
                new TecDetails() { TecherID = 5, FirstName = "SRon",LastName="Hulala",City="Karachi"}
                };



            var p = (from s in StdDetailsList
                     where s.City == "Lahore"
                     select s.FirstName).Concat
                    (from t in TecDetailsList
                     where t.City == "Lahore"
                     select t.FirstName);

                Console.WriteLine("*******************************");

                foreach (var std in p)
                {
                    Console.WriteLine("From seattle City : {0}",std);
            }
            }
       
    }

        public class StdDetails
        {

            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        public string City { get; set; }


    }
    public class TecDetails
    {

        public int TecherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}

