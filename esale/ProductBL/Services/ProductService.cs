using Product_DL;
using Product_DL.Repository;
using ProductDL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace ProductBL.Services
{
    public class ProductService
    {
        IProductRepo _productRepository;
        ProductDataContext _db;

        public ProductService(IProductRepo productRepository, ProductDataContext ProductDataContext)
        {
            this._productRepository = productRepository;
            _db = ProductDataContext;
        }
        public void AddProduct(Product product)
        {
            string productCode = string.Empty;
            _productRepository.GenerteProductCode(product, out productCode);
            product.ProductCode = productCode;
            _db.product.Add(product);
            _db.SaveChanges();  


            //switch (product.ChannelId)
            //{
            //    case 1:
            //        Random random = new Random();
            //        int a = random.Next(100, 999);
            //        product.ChannelId = product.ProductYear | a;
            //        break;
            //    case 2:
            //        var src_string = "qwertyuiopasdfghjklzxcvbnm01236789";
            //        var random1 = new Random();
            //        var str_builder = new StringBuilder();
            //        var alphnumeric_string = src_string[random1.Next(6)];
            //        str_builder.Append(alphnumeric_string);
            //        product.ChannelId = alphnumeric_string;
            //        break;
            //    case 3:
            //        int b = 10000000;

            //        break;
            //    default:
            //        {
            //            product.ChannelId = product.ChannelId;
            //            break;
            //        }
            //}
            //_productRepository.AddProduct(product);
        }
        public void UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product);
        }
        public void DeleteProduct(int ProductId)
        {
            _productRepository.DeleteProduct(ProductId);
        }
        //get movie by id
        public Product GetProductById(int ProductId)
        {
            return _productRepository.GetProductById(ProductId);
        }
        //get movies
        public IEnumerable<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
