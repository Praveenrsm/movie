using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private MovieContext _movieDbContext;
        public UserInfoRepository(MovieContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public UserInfo Login(UserInfo user)
        {
            UserInfo userInfo = null;
            var result = _movieDbContext.userInfo.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if (result.Count > 0)
            {
                userInfo = result[0];
            }
            return userInfo;
        }

        public void Register(UserInfo userInfo)
        {
            _movieDbContext.userInfo.Add(userInfo);
            _movieDbContext.SaveChanges();
        }
    }
}
