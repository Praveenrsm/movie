using movieentity1;
using System;
using System.Collections.Generic;
using System.Text;
using movieDataLayer.Repository;

namespace movieBL.services
{
    public class UserInfoService
    {
        private IUserInfoRepository _userInfoRepository;
        public UserInfoService(IUserInfoRepository userInfoRepository)
        {
            _userInfoRepository = userInfoRepository;
        }

        public void Register(UserInfo userInfo)
        {
            _userInfoRepository.Register(userInfo);
        }
        public UserInfo Login(UserInfo userInfo)
        {
            return _userInfoRepository.Login(userInfo);
        }
    }
}
