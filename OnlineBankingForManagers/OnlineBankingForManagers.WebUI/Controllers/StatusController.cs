using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Ninject.Activation;
using OnlineBankingForManagers.Domain.Abstract;
using OnlineBankingForManagers.Domain.Personages;
using OnlineBankingForManagers.WebUI.Models;

namespace OnlineBankingForManagers.WebUI.Controllers
{
    public class StatusController : Controller
    {
    //    public IPrincipal User = new IPrincipal();
     public static string user = "GUEST";
              public PartialViewResult UserBar()
        {

            StatusBar statusBar = new StatusBar();

          //  if ((User.Identity.IsAuthenticated != null))// && (User.Identity.IsAuthenticated))
            {
                user = "Home page for " + User.Identity.Name;
            }
           // else
            {
                user = "Home page for guest user.";
            }
            statusBar.UserName = user;
                  return PartialView(statusBar);
        }
             
}
    }

