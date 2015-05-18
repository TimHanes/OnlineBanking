using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineBankingForManagers.Domain.Personages
{
    class Role
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Login")]
        public string Code { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a Password")]
        public string Name { get; set; }
    }
}
