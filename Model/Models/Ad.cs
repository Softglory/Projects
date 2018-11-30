using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ad :IEntityBase
    {
        public Ad()
        {
            AdCountClick = 0;
        }
        public int AdId { get; set; }
        public string AdDescription { get; set; }
        public string AdImage { get; set; }
        public string AdCarrer { get; set; }
        public bool Status { get; set; }
        public int AdCountClick { get; set; }
        public string AdType { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
