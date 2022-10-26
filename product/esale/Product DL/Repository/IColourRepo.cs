using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_DL.Repository
{
    public interface IColourRepo
    {
        void AddColour(Colour colour);
        void UpdateColour(Colour colour);
        void DeleteColour(int colourid);
        Colour GetColourById(int colourid);
        IEnumerable<Colour> GetColours();
    }
}
