using movieentity1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace movieDataLayer.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private MovieContext _movieDbContext;
        public AdminRepository(MovieContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
        public Admin Login(Admin user)
        {
            Admin adminss = null;
            var result = _movieDbContext.admin.Where(obj => obj.Email == user.Email && obj.Password == user.Password).ToList();
            if (result.Count > 0)
            {
                adminss = result[0];
            }
            return adminss;
        }

        public void Register(Admin admins)
        {
            _movieDbContext.admin.Add(admins);
            _movieDbContext.SaveChanges();
        }
    }
}
