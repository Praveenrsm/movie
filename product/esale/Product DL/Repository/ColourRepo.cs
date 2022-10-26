using Microsoft.EntityFrameworkCore;
using Product_DL;
using Product_DL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductDL.Repository
{
    public class ColourRepo : IColourRepo
    {
        ProductDataContext _productdbcontext;
        public ColourRepo(ProductDataContext context)
        {
            this._productdbcontext = context;
        }
        public void AddColour(Colour col)
        {
            _productdbcontext.colour.Add(col);
            _productdbcontext.SaveChanges();
        }
        public void DeleteColour(int colid)
        {
            var colour = _productdbcontext.colour.Find(colid);
            _productdbcontext.colour.Remove(colour);
            _productdbcontext.SaveChanges();
        }
        public IEnumerable<Colour> GetColours()
        {
            return _productdbcontext.colour.ToList();
        }
        public Colour GetColourById(int colid)
        {
            return _productdbcontext.colour.Find(colid);
        }
        public void UpdateColour(Colour col)
        {
            _productdbcontext.Entry(col).State = EntityState.Modified;
            _productdbcontext.SaveChanges();
        }

    }
}
