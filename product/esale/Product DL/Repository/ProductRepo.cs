using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Product_DL.Repository
{
    

    public class ProductRepo : IProductRepo
    {
        ProductDataContext _productdbcontext;
    public ProductRepo(ProductDataContext context)
    {
        this._productdbcontext = context;
    }
    public void AddProduct(Product prod)
    {
        _productdbcontext.product.Add(prod);
        _productdbcontext.SaveChanges();
    }
    public void DeleteProduct(int prodId)
    {
        var product = _productdbcontext.product.Find(prodId);
        _productdbcontext.product.Remove(product);
        _productdbcontext.SaveChanges();
    }
    public IEnumerable<Product> GetProducts()
    {
        return _productdbcontext.product.ToList();
    }
    public Product GetProductById(int productid)
    {
        return _productdbcontext.product.Find(productid);
    }
    public void UpdateProduct(Product prod)
    {
        _productdbcontext.Entry(prod).State = EntityState.Modified;
        _productdbcontext.SaveChanges();
    }
        private static int Channel1Code = 001;
        private static long Channel3Code = 10000000;
        private static Random random =new Random();
        private const string chars = "qwertyuiopasdfghjklzxcvbnm1234567890";
        public void GenerteProductCode(Product product,out string code)
        {
            code = ComputerCode(product);
            while(CheckIfUnique(code))
            {
                code = ComputerCode(product);
            }
        }
        private string ComputerCode(Product product)
        {
            string code;
            switch (product.ChannelId)
            {
                case 1:
                    code = $"{product.ProductYear}00{Channel1Code}";
                    Channel1Code++;
                    break;
                case 2:
                    code = AlphanumericGenerator(6);
                    break;
                case 3:
                    code = $"{Channel3Code}";
                    Channel3Code++;
                    break;
                default:
                    code = "Invalid Code";
                    break;
            }
            return code;
        }
        private bool CheckIfUnique(string code)
        {
            return _productdbcontext.product.Any(x => x.ProductCode == code);

        }
        private string AlphanumericGenerator(int length)
        {
            var result = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return result;  
        }
        
    }
}
