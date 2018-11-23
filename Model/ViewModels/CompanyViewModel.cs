using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class CompanyViewModel
    {
        public int CompanyId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string CompanyName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string AboutUs { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone1 { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
