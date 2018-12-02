using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class ServiceConfiguration : EntityBaseConfiguration<Service>
    {
        public ServiceConfiguration()
        {
            ToTable("Services");
            //HasMany(x => x.Accounts)
            //    .WithMany(x => x.Services);
        }
    }
}
