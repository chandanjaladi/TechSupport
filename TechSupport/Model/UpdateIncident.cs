using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class UpdateIncident
    {
        public string CustomerName { get; set; }
        public string ProductCode { get; set; }
        public string TechnicianName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OpenedDate { get; set; }
        public string TextToAdd { get; set; }
    }
}
