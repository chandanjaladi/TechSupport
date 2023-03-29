namespace TechSupport.Model
{
    /// <summary>
    /// This class is for the incident model
    /// </summary>
    public class Incident
    {
        private string _title;
        private string _description;
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
                if (string.IsNullOrEmpty(value))
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Description cannot be empty!");
                }
                _description = value;
            }
        }
    }
}
