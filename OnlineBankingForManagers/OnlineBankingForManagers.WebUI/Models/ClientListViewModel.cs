using System.Collections.Generic;
using OnlineBankingForManagers.Domain.Personages;
using System.Web.Helpers;

namespace OnlineBankingForManagers.WebUI.Models
{
    public class ClientsListViewModel
    {

        public WebGrid Clients { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentAddress { get; set; }
       
    }
}