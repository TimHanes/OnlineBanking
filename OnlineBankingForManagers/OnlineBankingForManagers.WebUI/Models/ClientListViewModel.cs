using System.Collections.Generic;
using OnlineBankingForManagers.Domain.Personages;

namespace OnlineBankingForManagers.WebUI.Models
{
    public class ClientsListViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentAddress { get; set; }
    }
}