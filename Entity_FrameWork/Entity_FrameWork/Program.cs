using Entity_FrameWork.Models;
using System;
using System.Linq;

namespace Entity_FrameWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Code First Approach


            //DISPLAY VALUES-----------------------------------------------

            //var db = new LearnEntityFrameWorkCoreDb();
            //var avgPrice = db.Products.Average(p => p.Price);
            //Console.WriteLine("Average Price = " + avgPrice);
            //var max = db.Products.Max(p => p.Price);
            //Console.WriteLine("The Biggest price is = " + max);
            //var min = db.Products.Min(p => p.Price);
            //Console.WriteLine("The smallest price is = " + min);
            //var products = db.Products.OrderByDescending(p => p.Price).Skip(0).Take(2).ToList();
            //var products = db.Products.OrderBy(p => p.Price).ToList();
            //var products = db.Products.Where(p => p.Name.EndsWith("top 1")).ToList();
            //var products = db.Products.Where(p => p.Name.Contains("bi")).ToList();
            //var products = db.Products.Where(p => p.Price >= 15 && p.Price <= 20).ToList();
            //var products = db.Products.Where(p => p.CategoryId == 1 || p.CategoryId == 2).ToList();
            //var products = db.Products.Where(p => p.Price > 22).ToList();
            //var products = db.Products.Where(p => p.Status == true).ToList();
            //var products = db.Products.Where(p => p.Status == true).ToList();
            //foreach (var p in products)
            //{
            //    Console.WriteLine("ID               :" + p.Id);
            //    Console.WriteLine("Name             :" + p.Name);
            //    Console.WriteLine("Price            :" + p.Price);
            //    Console.WriteLine("Qunatity         :" + p.Quantity);
            //    Console.WriteLine("Creation Date    :" + p.CreationDate.ToString("MM/dd/yyyy"));
            //    Console.WriteLine("Status           :" + p.Status);
            //    Console.WriteLine("CategoryId       :" + p.Category.Id);
            //    Console.WriteLine("Category Name    :" + p.Category.Name);
            //    Console.WriteLine("==================================================");

            //}

            // INSERTING VALUES-----------------------------------------

            //var db = new LearnEntityFrameWorkCoreDb();

            //var product = new Product()
            //{
            //    Name = "Tivi 3",
            //    Price = 12,
            //    Quantity = 3,
            //    CreationDate = DateTime.Now,
            //    Status = true,
            //    CategoryId = 3

            //};

            //db.Products.Add(product);
            //Console.WriteLine("Result: "+db.SaveChanges());

            // UPDATING DATA---------------------------------------------

            //var db = new LearnEntityFrameWorkCoreDb();
            //var product = db.Products.SingleOrDefault(p => p.Id == 7);
            //product.Name = "Tivi2";
            //product.Price = 36;
            //product.Status = true;

            //Console.WriteLine("Result: " + db.SaveChanges());

            //DELETE VALUES ---------------------------------------------
            var db = new LearnEntityFrameWorkCoreDb();
            var product = db.Products.SingleOrDefault(p => p.Id == 7);
            db.Products.Remove(product);
            Console.WriteLine("Result: " + db.SaveChanges());
            Console.ReadLine();
        }
    }
}