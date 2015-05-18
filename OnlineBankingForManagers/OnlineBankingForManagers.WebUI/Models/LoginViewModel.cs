﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingForManagers.WebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Status")]
        public StatusBar StatusBar { get; set; }
        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить")]
        public bool RememberMe { get; set; }
    }
   
} 