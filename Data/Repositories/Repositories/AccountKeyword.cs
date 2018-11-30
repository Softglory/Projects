using Data.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class AccountKeywordRepository : EntityBaseRepository<AccountKeyword>, IAccountKeywordRepository
    {
        public AccountKeywordRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
