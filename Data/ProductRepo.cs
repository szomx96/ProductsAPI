using System;
using System.Collections.Generic;
using System.Linq;
using productAPI.Models;

namespace productAPI.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductContext _context;

        public ProductRepo(ProductContext context)
        {
            _context = context;
        }

        public void CreateProduct(ProductModel product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Add(product);
        }

        public void DeleteProduct(ProductModel product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            _context.Products.Remove(product);
        }

        public ProductModel GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return _context.Products.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(ProductModel product)
        {

        }
    }

}