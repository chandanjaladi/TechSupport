namespace TechSupport.Model
{
    /// <summary>
    /// This class is for the incident model
    /// </summary>
    public class Incident
    {
        private string _title;
        private string _description;
        private int _customerID;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public Incident()
        {
            _title = "";
            _description = "";
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        /// <exception cref="System.ArgumentNullException"></exception>
        public string Title
        {
            get => _title;

            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException(paramName: "", message: "Title cannot be empty!");
                }
                _title = value;
            }
        }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        /// <exception cref="System.Exception">Description cannot be empty!</exception>
        public string Description
        {
            get => _description;

            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Description cannot be empty!");
                }
                _description = value;
            }
        }
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        /// <value>
        /// The customer identifier.
        /// </value>
        /// <exception cref="System.ArgumentException">CustomerID cannot be less than 0!</exception>
        public int CustomerID
        {
            get => _customerID;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("CustomerID cannot be less than 0!");
                }
                _customerID = value;
            }
        }
    }
}
