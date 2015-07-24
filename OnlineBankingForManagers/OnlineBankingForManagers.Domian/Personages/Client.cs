using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineBankingForManagers.Domain.Personages
{
    public class Client
    {
         [HiddenInput(DisplayValue = false)]
        public int ClientId { get; set; }

         [Required(ErrorMessage = "Please enter a Login")]
        public string Login { get; set; }
<<<<<<< HEAD
        
=======

        [DataType(DataType.Password)]
>>>>>>> 02845c5c33b5b6672c0cde399ce368e726430001
        [Required(ErrorMessage = "Please enter a Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
              [Required(ErrorMessage = "Please enter a Email")]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
              [Required(ErrorMessage = "Please enter a Address")]
              [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        
      //  public string Vip { get; set; }
  
    }
}
