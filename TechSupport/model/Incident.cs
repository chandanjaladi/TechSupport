namespace TechSupport.Model
{
    public class Incident
    {
        private string _title;
        private string _description;
        private int _customerID;


        public string Title
        {
            get => _title;

            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Title cannot be empty!");
                }
                _title = value;
            }
        }

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
