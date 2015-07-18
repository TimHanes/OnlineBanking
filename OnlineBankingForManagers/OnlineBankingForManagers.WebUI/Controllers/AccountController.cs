﻿using System.Web.Mvc;
using OnlineBankingForManagers.Domain.Abstract;

using OnlineBankingForManagers.WebUI.Models;
using OnlineBankingForManagers.Domain.Personages;
using OnlineBankingForManagers.WebUI.Infrastructure.Abstract;

namespace OnlineBankingForManagers.WebUI.Controllers
{
    public class AccountController : Controller
    {

        private IAuthProvider authProvider;
        private IAuthCookie authCookie;

        public AccountController(IAuthProvider auth, IAuthCookie cookie)
        {
            authProvider = auth;
            authCookie = cookie;
        }
        
     
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            
            if (ModelState.IsValid)
            {
                

                if (authProvider.AuthUser(model.UserName, model.Password))
                {
                    authCookie.AuthCookie(model.UserName, model.RememberMe);
              
                    
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return Redirect(Url.Action("List", "Client")); 
                    }                                      
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
               
                return View();
            }
        }
        public ActionResult LogOff()
        {
            authCookie.AuthCookieOff();
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            User user = new User();
            user.Login = model.UserName;
            user.Password = model.Password;
            user.Email= model.Email;
            user.Address = model.Address;
            if (ModelState.IsValid)
            {
              
                if (authProvider.CreateUser(user))
                {
                   
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Ошибка при регистрации");
                }
            }

            return View(model);
        }

    }
}
