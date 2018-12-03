using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            Keywords = new List<AccountKeyword>();
            AccountServices = new List<AccountService>();
            SelectedServices = new List<int>();
        }
        public int AccountId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string LastName { get; set; }
        public string FirstNameEn { get; set; }
        public string LastNameEn { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string CardImage { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string ProfessionTitle { get; set; }
        public string ProfessionTitleEn { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public int? CompanyId { get; set; }
        public string Location { get; set; }
        [Url(ErrorMessage = "Please enter a valid url")]
        public string FacebookUrl { get; set; }
        [Url(ErrorMessage = "Please enter a valid url")]
        public string TwitterUrl { get; set; }
        [Url(ErrorMessage = "Please enter a valid url")]
        public string Website { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int NoOfSearches { get; set; }
        public List<AccountKeyword> Keywords { get; set; }
        public List<AccountService> AccountServices { get; set; }
       
        public Company Company { get; set; }

        public List<int> SelectedServices { get; set; }
    }
}
