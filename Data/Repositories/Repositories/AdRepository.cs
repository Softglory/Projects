﻿using Data.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class AdRepository : EntityBaseRepository<Ad>, IAdRepository
    {
        public AdRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }
}
