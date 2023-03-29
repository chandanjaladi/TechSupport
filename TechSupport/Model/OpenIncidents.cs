namespace TechSupport.Model
{
    /// <summary>
    /// This is the open incidents structure
    /// </summary>
    public class OpenIncidents
    {
        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>
        /// The product code.
        /// </value>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        /// <value>
        /// The date opened.
        /// </value>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the techinician.
        /// </summary>
        /// <value>
        /// The name of the techinician.
        /// </value>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}
