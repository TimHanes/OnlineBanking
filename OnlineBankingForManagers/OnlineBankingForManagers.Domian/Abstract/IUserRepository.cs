using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OnlineBankingForManagers.Domain.Personages;

namespace OnlineBankingForManagers.Domain.Abstract
{
   public interface IUserRepository
    {
       User Login(string userName, string password);
       IQueryable<User> Users { get; }

     //  IQueryable<Role> Roles { get; }

    //   bool CreateRole(Role instance);

    //   bool UpdateRole(Role instance);

    //   bool RemoveRole(int idRole);

    }

}
