using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ProductEntity;
using Size = ProductEntity.Size;

namespace Product_DL.Repository
{
    public class SizeRepo :ISizeRepo
    {
        ProductDataContext _productdbcontext;
        public SizeRepo(ProductDataContext context)
        {
            this._productdbcontext = context;
        }
        public void AddSize(Size siz)
        {
            _productdbcontext.size.Add(siz);
            _productdbcontext.SaveChanges();
        }
        public void DeleteSize(int sizid)
        {
            var size = _productdbcontext.size.Find(sizid);
            _productdbcontext.size.Remove(size);
            _productdbcontext.SaveChanges();
        }
        public IEnumerable<Size> GetSizes()
        {
            return _productdbcontext.size.ToList();
        }
        public Size GetSizeById(int sizid)
        {
            return _productdbcontext.size.Find(sizid);
        }
        public void UpdateSize(Size siz)
        {
            _productdbcontext.Entry(siz).State = EntityState.Modified;
            _productdbcontext.SaveChanges();
        }

    }
}
