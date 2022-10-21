using movieDataLayer.Repository;
using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieBL.services
{
    public class AdminService
    {
        private IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository =adminRepository;
        }

        public void Register(Admin admin)
        {
            _adminRepository.Register(admin);
        }
        public Admin Login(Admin admin)
        {
            return _adminRepository.Login(admin);
        }
    }
}
