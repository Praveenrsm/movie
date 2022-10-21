using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_DL.Repository
{
    public interface ISizeRepo
    {
        void AddSize(Size size);
        void UpdateSize(Size size);
        void DeleteSize(int sizeid);
        Size GetSizeById(int sizeid);
        IEnumerable<Size> GetSizes();
    }
}
