using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountServiceConfiguration : EntityBaseConfiguration<AccountService>
    {
        public AccountServiceConfiguration()
        {
            ToTable("AccountServices");
           // HasKey(x => new { x.AccountId, x.ServiceId }); //Composite Key 
        }
    }
}
