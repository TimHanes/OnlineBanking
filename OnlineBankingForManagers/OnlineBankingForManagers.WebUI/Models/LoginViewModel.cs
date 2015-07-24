using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingForManagers.WebUI.Models
{
    public class LoginViewModel
    {
        
<<<<<<< HEAD
        public StatusBar StatusBar { get; set; }
=======
>>>>>>> 02845c5c33b5b6672c0cde399ce368e726430001
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