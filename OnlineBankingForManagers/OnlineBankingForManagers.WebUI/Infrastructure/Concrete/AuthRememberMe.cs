using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;

using OnlineBankingForManagers.WebUI.Controllers;
using OnlineBankingForManagers.WebUI.Infrastructure.Abstract;
using OnlineBankingForManagers.WebUI.Models;


namespace OnlineBankingForManagers.WebUI.Infrastructure.Concrete
{
    public class AuthRememberMe : IAuthCookie
    {
        public void AuthCookie(string login, bool rememberMe)
        {
          FormsAuthentication.SetAuthCookie(login, rememberMe);
           
        }

        public void AuthCookieOff()
        {
            FormsAuthentication.SignOut();
        }
       

    }
    
}