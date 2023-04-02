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
        private string _productCode;
        private DateTime _openedDate;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public Incident()
        {
            _customerID = 0;
            _productCode = "";
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Title cannot be empty!");
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
                if (string.IsNullOrEmpty(value))
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
        public int CustomerID
        {
            get => _customerID;

            set
            {
                _customerID = value;
            }
        }

        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>
        /// The product code.
        /// </value>
        public string ProductCode
        {
            get => _productCode;

            set
            {
                _productCode = value;
            }
        }

        /// <summary>
        /// Gets or sets the opened date.
        /// </summary>
        /// <value>
        /// The opened date.
        /// </value>
        public DateTime OpenedDate { get => _openedDate; set => _openedDate = value; }
    }
}
