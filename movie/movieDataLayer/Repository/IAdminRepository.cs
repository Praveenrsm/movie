using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface IAdminRepository
    {
        void Register(Admin admin);
        Admin Login(Admin admins);
    }
}
