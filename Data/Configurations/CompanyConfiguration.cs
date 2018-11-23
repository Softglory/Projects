using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class CompanyConfiguration : EntityBaseConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            ToTable("Companies");
        }
    }
}
