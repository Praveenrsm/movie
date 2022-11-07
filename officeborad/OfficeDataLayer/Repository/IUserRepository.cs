using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeDataLayer.Repository
{
    public interface IUserRepository
    {
        void Register(user user);
        user Login(user user);
    }
}
