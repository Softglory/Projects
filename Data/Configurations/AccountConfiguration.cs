using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountConfiguration : EntityBaseConfiguration<Account>
    {
        public AccountConfiguration()
        {
            ToTable("Accounts");
            //HasMany(x => x.Services)
            //    .WithMany(x => x.Accounts);

        }
    }
}
