using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using OnlineBankingForManagers.Domain.Abstract;
using OnlineBankingForManagers.Domain.Personages;

namespace OnlineBankingForManagers.Domain.Concrete
{
   public class EntityFrameworkUserRepository: IUserRepository
    {
        private EntityFrameworkDbContext Db = new EntityFrameworkDbContext();
        public IQueryable<User> Users
        {
            get { return Db.Users; }
        }
      //  [Inject]
      //  public EntityFrameworkDbContext Db { get; set; }

     /*   public IQueryable<Role> Roles
        {
            get { throw new NotImplementedException(); }
        }

        public bool CreateRole(Role instance)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRole(Role instance)
        {
            throw new NotImplementedException();
        }

        public bool RemoveRole(int idRole)
        {
            throw new NotImplementedException();
        }*/
        public User Login(string login, string password)
        {
            return Db.Users.FirstOrDefault(p => string.Compare(p.Login, login, true)
                == 0 && p.Password == password);
        }
        public User GetUser(string email)
        {
            return Db.Users.FirstOrDefault(p => string.Compare(p.Login, email, true) == 0);
        }
     /*   public bool Login(string login, string password)
        {
            User dbUser = Db.Users
                 .FirstOrDefault(p => p.Login == login);

            if ((dbUser != null) && (dbUser.Password == password)) return true;
            else return false;
        }*/
    }
}
