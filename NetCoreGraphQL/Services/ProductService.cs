using NetCoreGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Coffee", Price = 10},
            new Product() { Id = 2, Name = "Tea", Price = 15},
        };

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {
            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);            
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}
