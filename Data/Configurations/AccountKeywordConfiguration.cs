using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    public class AccountKeywordConfiguration : EntityBaseConfiguration<AccountKeyword>
    {
        public AccountKeywordConfiguration()
        {
            ToTable("AccountKeywords");
        }
    }
}
