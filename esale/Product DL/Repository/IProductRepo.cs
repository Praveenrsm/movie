using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_DL.Repository
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productid);
        Product GetProductById(int productid);
        IEnumerable<Product> GetProducts();
        void GenerteProductCode(Product product,out string ProductCode);
    }
}
