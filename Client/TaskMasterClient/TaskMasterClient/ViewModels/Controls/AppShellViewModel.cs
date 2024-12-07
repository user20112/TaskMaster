using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMasterClient.ViewModels
{
    public class AppShellViewModel:BaseViewModel
    {
        public string PartnersProfileImage { get; set; }
        public string PartnerName { get; set; }
        public string PartnerRole { get; set; }
        public bool IsBusy { get; set; }
    }
}
