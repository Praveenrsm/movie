using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;

namespace movieDataLayer.Repository
{
    public interface IUserInfoRepository
    {
        void Register(UserInfo userInfo);
        UserInfo Login(UserInfo user);
    }
}
