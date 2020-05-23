using System.Collections.Generic;
using productAPI.Models;

namespace productAPI.Data
{
    public interface IProductRepo
    {
        bool SaveChanges();
        IEnumerable<ProductModel> GetProducts();
        ProductModel GetProductById(int id);
        void CreateProduct(ProductModel product);
        void UpdateProduct(ProductModel product);
        void DeleteProduct(ProductModel product);
    }
}