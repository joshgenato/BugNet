using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace BugNet.Data
{
    public class SqlUserAPIRepo : IIdentityAPIRepo
    {
        private readonly IdentityContext _context;

        public SqlUserAPIRepo(IdentityContext context)
        {
            _context = context;
        }
        public void CreateUser(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IdentityUser> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public IdentityUser GetUserById(string Id)
        {
            return _context.Users.FirstOrDefault(user => user.Id == Id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateUser(IdentityUser user)
        {
            throw new System.NotImplementedException();
        }
    }
}