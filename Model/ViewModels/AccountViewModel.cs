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
        public int AccountId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string LastName { get; set; }
        public string CardImage { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string ProfessionTitle { get; set; }
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
        public Company Company { get; set; }
    }
}
