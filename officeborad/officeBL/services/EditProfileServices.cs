using OfficeDataLayer.Repository;
using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace officeBL.services
{
    public class EditProfileServices
    {
        IProfileEditRepository _profileeditRepository;
        public EditProfileServices(IProfileEditRepository profileeditRepository)
        {
            this._profileeditRepository = profileeditRepository;
        }
        public void UpdateProfile(Profile profile)
        {
            _profileeditRepository.UpdateProfile(profile);
        }
    }
}
