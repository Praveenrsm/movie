using Product_DL.Repository;
using ProductEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBL.Services
{
    public class SizeService
    {
        ISizeRepo _sizeRepository;
        public SizeService(ISizeRepo sizeRepository)
        {
            this._sizeRepository = sizeRepository;
        }
        public void AddSize(Size size)
        {
            _sizeRepository.AddSize(size);
        }
        public void UpdateSize(Size size)
        {
            _sizeRepository.UpdateSize(size);
        }
        public void DeleteSize(int SizeId)
        {
            _sizeRepository.DeleteSize(SizeId);
        }
        //get movie by id
        public Size GetSizeById(int SizeId)
        {
            return _sizeRepository.GetSizeById(SizeId);
        }
        //get movies
        public IEnumerable<Size> GetSizes()
        {
            return _sizeRepository.GetSizes();
        }
    }
}
