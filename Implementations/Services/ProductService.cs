using InterfaceMiniAppPractice.Abstractions.Services;
using InterfaceMiniAppPractice.Models;
using InterfaceMiniAppPractice.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMiniAppPractice.Implementations.Services
{
    internal class ProductService : IProductService
    {
        Product[] products = { };
        public void Create()
        {
            Product product = new Product();
            product.Id = products.Length + 1;

            Console.WriteLine("Product name");
            product.Name = Console.ReadLine();

            Console.WriteLine("Product price");
            product.Price = double.Parse(Console.ReadLine());

            Array.Resize(ref products, products.Length+1);
            products[products.Length-1] = product;
        }

        public void Show()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        
    }
}
