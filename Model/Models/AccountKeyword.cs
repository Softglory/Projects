using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountKeyword : IEntityBase
    {
        public int AccountKeywordId { get; set; }
        public int AccountId { get; set; }
        public string KeyWord { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Account  Account { get; set; }
    }
}
