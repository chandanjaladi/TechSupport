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
        /// Specifics the customer incidents.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <returns>Incidents of specific customers</returns>
        public List<Incident> specificCustomerIncidents(int customerID) 
        {
            return _incidentDal.getSpecificCustomerIncidents(customerID);
        }
    }
}
