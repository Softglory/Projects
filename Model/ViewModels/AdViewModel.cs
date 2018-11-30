using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModels
{
    public class AdViewModel
    {
        public int AdId { get; set; }
        //[Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string AdDescription { get; set; }
        public string AdImage { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "مطلوب")]
        public string AdCarrer { get; set; }
        public bool Status { get; set; }
        public string AdType { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
