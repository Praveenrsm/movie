using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeDataLayer.Repository
{
    public interface IProfileEditRepository
    {
        void UpdateProfile(Profile profile);
    }
}
