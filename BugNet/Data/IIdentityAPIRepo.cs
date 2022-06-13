using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BugNet.Data
{
    public interface IIdentityAPIRepo
    {
        bool SaveChanges();
        IEnumerable<IdentityUser> GetAllUsers();
        IdentityUser GetUserById(string Id);
        void CreateUser(IdentityUser user);
        void UpdateUser(IdentityUser user);
        void DeleteUser(IdentityUser user);
    }
}