using Microsoft.EntityFrameworkCore;
using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeDataLayer.Repository
{
    public class ProfileEditRepository : IProfileEditRepository
    {
        Office_Context _officecontext;
        public ProfileEditRepository(Office_Context context)
        {
            this._officecontext = context;
        }
        public void UpdateProfile(Profile profile)
        {
            _officecontext.Entry(profile).State = EntityState.Modified;
            _officecontext.SaveChanges();
        }
    }
}
