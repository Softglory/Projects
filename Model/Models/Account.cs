using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Account : IEntityBase
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
        public string Email { get; set; }
        public string CardImage { get; set; }
        public string ProfessionTitle { get; set; }
        public string ProfessionTitleEn { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string Website { get; set; }
        public int? CompanyId { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Company Company { get; set; }
        public List<AccountKeyword> Keywords { get; set; }

    }
}
