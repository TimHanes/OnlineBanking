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
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }
              [Required(ErrorMessage = "Please enter a Email")]
        public string Email { get; set; }
              [Required(ErrorMessage = "Please enter a Address")]
        public string Address { get; set; }
  
    }
}
