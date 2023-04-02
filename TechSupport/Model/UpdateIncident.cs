using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// This class is used to create objects of Update Incidents
    /// </summary>
    public class UpdateIncident
    {
        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>
        /// The product code.
        /// </value>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the technician.
        /// </summary>
        /// <value>
        /// The name of the technician.
        /// </value>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the opened date.
        /// </summary>
        /// <value>
        /// The opened date.
        /// </value>
        public DateTime OpenedDate { get; set; }

        /// <summary>
        /// Gets or sets the closed date.
        /// </summary>
        /// <value>
        /// The closed date.
        /// </value>
        public DateTime ClosedDate { get; set; }

        /// <summary>
        /// Gets or sets the text to add.
        /// </summary>
        /// <value>
        /// The text to add.
        /// </value>
        public string TextToAdd { get; set; }

        /// <summary>
        /// Gets or sets the incident identifier.
        /// </summary>
        /// <value>
        /// The incident identifier.
        /// </value>
        public int IncidentID { get; set; }
    }
}
