using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SearchCount :IEntityBase
    {
        public int SearchCountId { get; set; }
        public int AccountId { get; set; } // Account being searched 
        public int SearchById { get; set; } // Who searched
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Account SearchBy { get; set; }
        public Account Account { get; set; }
    }
}
