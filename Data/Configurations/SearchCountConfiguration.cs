using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class SearchCountConfiguration : EntityBaseConfiguration<SearchCount>
    {
        public SearchCountConfiguration()
        {
            ToTable("SearchCounts");
            HasKey(s => s.SearchCountId);
            HasRequired(s => s.Account) .WithMany().HasForeignKey(c => c.AccountId);
            HasRequired(s => s.SearchBy).WithMany().HasForeignKey(c => c.SearchById);
        }
    }
}
