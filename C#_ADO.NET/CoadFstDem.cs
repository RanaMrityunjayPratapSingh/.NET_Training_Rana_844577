using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
namespace CoadFstDem
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductDBContext context = new ProductDBContext();
            var product = context.Products;

            var product1 = product.Add(new Product()
            {
                ProductID = 1,
                name = "Badam drinks",
                price = 99.99,
                quantity = "500 ml",
                CategoryID = 1
            });

            var product2 = product.Add(new Product()
            {
                ProductID = 2,
                name = "Coffee drinks",
                price = 59.99,
                quantity = "250 ml",
                CategoryID = 1
            });
           
                

            var product3 = product.Add(new Product()
            {
                ProductID = 3,
                name = "Coke drinks",
                price = 49.99,
                quantity = "100 ml",
                CategoryID = 1
            });

            context.SaveChanges();
        }
    }
    public class ProductDBContext:DbContext
    {
        public ProductDBContext() : base("name =ProductDBContext ")
        {}
    public DbSet<Product> Products { get; set; }

}



    public class Product
    {
        public int ProductID { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public string quantity { get; set; }

        public int CategoryID { get; set; }



        public class Category
        {
            public int CategoryID { get; set; }
            public string Name { get; set; }
        }
}
}
