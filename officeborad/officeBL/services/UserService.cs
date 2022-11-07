using OfficeDataLayer.Repository;
using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace officeBL.services
{
    public class UserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(user user)
        {
            _userRepository.Register(user);
        }
        public user Login(user user)
        {
            return _userRepository.Login(user);
        }
    }
}
