using System.Linq;
using System.Security.Principal;
using System.Web;
using OnlineBankingForManagers.Domain.Personages;

namespace OnlineBankingForManagers.WebUI.Infrastructure.Abstract
{
    public interface IAuthCookie
    {
        void AuthCookie(string login, bool rememberMe);
        void AuthCookieOff();
     
    }
}
