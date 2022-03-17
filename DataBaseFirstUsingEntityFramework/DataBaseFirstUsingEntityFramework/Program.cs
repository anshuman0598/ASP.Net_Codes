using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstUsingEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var cont = new Training3Entities())
            {
                var result = cont.Products;
                foreach(var product in result)
                {
                    Console.WriteLine("Product ID       = "+ product.Id);
                    Console.WriteLine("Product name     = "+ product.Name);
                    Console.WriteLine("Product Price    = "+ product.Price);
                    Console.WriteLine("Product Qunatity = "+ product.Quantity);
                    Console.Read();
                    Console.WriteLine();
                }
            }
        }
    }
}
