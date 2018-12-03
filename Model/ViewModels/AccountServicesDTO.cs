using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class AccountServicesDTO
    {
        public int ServiceId { get; set; }
        public string  ServiceName { get; set; }
        public bool IsSelected { get; set; }
    }
}
