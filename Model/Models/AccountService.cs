using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountService : IEntityBase
    {
        public int AccountServiceId { get; set; }
        public int AccountId { get; set; }
        public int ServiceId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Account Account { get; set; }
        public Service Service { get; set; }
    }
}
