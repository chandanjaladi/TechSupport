using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// This class is incident controller
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL _incidentDal;
        private IncidentDBDal _incidentDBDAL;
        private string _username = "jane";
        private string _password = "test1234";

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public IncidentController()
        {
            _incidentDal = new IncidentDAL();
            _incidentDBDAL = new IncidentDBDal();
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <returns>Username of user</returns>
        public string GetUsername()
        {
            return _username;
        }

        /// <summary>
        /// Gets the open incidents.
        /// </summary>
        /// <returns></returns>
        public List<OpenIncidents> GetOpenIncidents() 
        {
            return _incidentDBDAL.GetOpenIncidents();
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <returns>password of user</returns>
        public string GetPassword()
        {
            return _password;
        }
        /// <summary>
        /// Gets the incidents.
        /// </summary>
        /// <returns>list of incidents</returns>
        public List<Incident> GetIncidents()
        {
            return _incidentDal.GetIncidents();
        }
        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void Add(Incident incident)
        {
            _incidentDal.Add(incident);
        }

        /// <summary>
        /// Gets the customer names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetCustomerNames()
        {
            return _incidentDBDAL.GetCustomerNames();
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetProductNames()
        {
            return _incidentDBDAL.GetProductNames();
        }

        /// <summary>
        /// Checks if the customer and product is registered or not.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public bool CheckRegisteredOrNot(int customerID, string productCode)
        {
            return _incidentDBDAL.CheckRegisteredProductOrNot(customerID,productCode);
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public void AddIncident(Incident myIncident)
        {
            _incidentDBDAL.AddIncident(myIncident);
        }

        /// <summary>
        /// Gets the customer ID.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <returns></returns>
        public int GetCustomerID(string customerName)
        {
            return _incidentDBDAL.GetCustomerID(customerName);
        }

        /// <summary>
        /// Gets the product code.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public string GetProductCode(string productName)
        {
            return _incidentDBDAL.GetProductCode(productName);
        }

        /// <summary>
        /// Gets the particular incident.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns></returns>
        public UpdateIncident GetParticularIncident(int incidentID)
        {
            return _incidentDBDAL.GetParticularIncident(incidentID);
        }

        /// <summary>
        /// Gets the technicians names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetTechniciansNames()
        {
            return _incidentDBDAL.GetTechinicansNames();
        }

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="myIncident">My incident.</param>
        public void UpdateIncident(UpdateIncident myIncident)
        {
            _incidentDBDAL.UpdateIncident(myIncident);
        }

        /// <summary>
        /// Closes the incident.
        /// </summary>
        /// <param name="myIncident">My incident.</param>
        public void CloseIncident(UpdateIncident myIncident)
        {
            _incidentDBDAL.CloseIncident(myIncident);
        }
    }
}
