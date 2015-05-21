using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBankingForManagers.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            var cookie = new HttpCookie("new")
            {
                Name = "test_cookie",
                Value = DateTime.Now.ToString("dd.MM.yyyy"),
                Expires = DateTime.Now.AddMinutes(10),
            };
            Response.SetCookie(cookie);
            StatusController.user = cookie.Name;
        }

    }
}
