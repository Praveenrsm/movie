using Product_DL.Repository;
using ProductDL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBL.Services
{
    public class ColourService
    {
        IColourRepo _colourRepository;
        public ColourService(IColourRepo colourRepository)
        {
            this._colourRepository = colourRepository;
        }
        public void AddColour(Colour colour)
        {
            _colourRepository.AddColour(colour);
        }
        public void UpdateColour(Colour colour)
        {
            _colourRepository.UpdateColour(colour);
        }
        public void DeleteColour(int colourId)
        {
            _colourRepository.DeleteColour(colourId);
        }
        //get movie by id
        public Colour GetColourById(int colourId)
        {
            return _colourRepository.GetColourById(colourId);
        }
        //get movies
        public IEnumerable<Colour> GetColours()
        {
            return _colourRepository.GetColours();
        }

    }
}
