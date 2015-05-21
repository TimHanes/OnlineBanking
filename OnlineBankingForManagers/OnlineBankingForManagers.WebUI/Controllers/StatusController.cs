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
            var cookie = new HttpCookie("new")
            {
                Name = "test_cookie",
                Value = DateTime.Now.ToString("dd.MM.yyyy"),
                Expires = DateTime.Now.AddMinutes(10),
            };
            Response.SetCookie(cookie);
           user = cookie.Name;
            statusBar.UserName = user;
                  return PartialView(statusBar);
        }
             
}
    }

