using NetCoreGraphQL.Data;
using NetCoreGraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreGraphQL.Services
{
    public class ProductService : IProduct
    {
        private GraphQLDbContext _dbContext;

        public ProductService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //private static List<Product> products = new List<Product>()
        //{
        //    new Product() { Id = 1, Name = "Coffee", Price = 10},
        //    new Product() { Id = 2, Name = "Tea", Price = 15},
        //};

        public Product AddProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _dbContext.Products.Find(id);            
        }

        public Product UpdateProduct(int id, Product product)
        {
            //_dbContext.Products[id] = product;
            var productObj = _dbContext.Products.Find(id);
            productObj.Name = product.Name;
            productObj.Price = product.Price;
            _dbContext.Products.Update(productObj);
            _dbContext.SaveChanges();
            return product;
        }
    }
}
