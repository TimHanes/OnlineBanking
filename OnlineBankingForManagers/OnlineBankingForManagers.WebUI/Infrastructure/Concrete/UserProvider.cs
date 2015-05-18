using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using OnlineBankingForManagers.Domain.Abstract;
using OnlineBankingForManagers.Domain.Concrete;

namespace OnlineBankingForManagers.WebUI.Infrastructure.Concrete
{
    public class UserProvider : IPrincipal
    {
        private UserIndentity userIdentity { get; set; }

        #region IPrincipal Members

        public IIdentity Identity
        {
            get
            {
                return userIdentity;
            }
        }

        public bool IsInRole(string role)
        {
            if (userIdentity.User == null)
            {
                return false;
            }
            return userIdentity.User.Equals(role);
        }
        
        #endregion


        public UserProvider(string name, EntityFrameworkUserRepository repository)
        {
            userIdentity = new UserIndentity();
            userIdentity.Init(name, repository);
        }


        public override string ToString()
        {
            return userIdentity.Name;
        }





        public bool InRoles(string roles)
        {
            if (string.IsNullOrWhiteSpace(roles))
            {
                return false;
            }

            var rolesArray = roles.Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var role in rolesArray)
            {
             //   var hasRole = UserRoles.Any(p => string.Compare(p.Role.Code, role, true) == 0);
               // if (hasRole)
            //    {
            //        return true;
             //  }
            }
            return true; // false;
        }
    }
}