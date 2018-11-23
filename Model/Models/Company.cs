using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Company :IEntityBase
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string AboutUs { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<Account> Accounts { get; set; }
    }
}
