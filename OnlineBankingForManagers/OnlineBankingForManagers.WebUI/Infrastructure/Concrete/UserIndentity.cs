using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using OnlineBankingForManagers.Domain.Concrete;
using OnlineBankingForManagers.Domain.Personages;
using OnlineBankingForManagers.Domain.Abstract;

namespace OnlineBankingForManagers.WebUI.Infrastructure.Concrete
{
    public class UserIndentity : IIdentity
    {
        public User User { get; set; }

        public string AuthenticationType
        {
            get
            {
                return typeof(User).ToString();
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return User != null;
            }
        }

        public string Name
        {
            get
            {
                if (User != null)
                {
                    return User.Email;
                }
                //иначе аноним
                return "anonym";
            }
        }

        public void Init(string email, EntityFrameworkUserRepository repository)
        {
            if (!string.IsNullOrEmpty(email))
            {
                User = repository.GetUser(email);
            }
        }
        public bool InRoles(string roles)
        {
            if (string.IsNullOrWhiteSpace(roles))
            {
                return false;
            }

            var rolesArray = roles.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
        /*    foreach (var role in rolesArray)
            {
                var hasRole = UserRoles.Any(p => string.Compare(p.Role.Code, role, true) == 0);
                if (hasRole)
                {
                    return true;
                }
            }*/
            return true;// false;
        }
    }
}