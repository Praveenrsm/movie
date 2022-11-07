using OfficeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfficeDataLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private Office_Context _OfficeContext;
        public UserRepository(Office_Context OfficeContext)
        {
            _OfficeContext = OfficeContext;
        }
        public user Login(user users)
        {
            user user = null;
            var result = _OfficeContext.user.Where(obj => obj.Email == users.Email && obj.Password == users.Password).ToList();
            if (result.Count > 0)
            {
                user = result[0];
            }
            return users;
        }

        public void Register(user users)
        {
            _OfficeContext.user.Add(users);
            _OfficeContext.SaveChanges();
        }
    }
}
