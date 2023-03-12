using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class is for Incident data access layer between model and view
    /// </summary>
    public class IncidentDAL
    {
        private static readonly List<Incident> s_incidents = new List<Incident>();
        private List<Incident> customerIncidents = new List<Incident>();
        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void Add(Incident incident)
        {
            s_incidents.Add(incident);
        }
        /// <summary>
        /// Gets the incidents.
        /// </summary>
        /// <returns>List of incidents</returns>
        public List<Incident> GetIncidents()
        {
            return s_incidents;
        }
        /// <summary>
        /// Gets the customer incidents.
        /// </summary>
        /// <returns>List of customer incidents</returns>
        public List<Incident> GetCustomerIncidents()
        {
            return customerIncidents;
        }

        /// <summary>
        /// Adds the incidents of customers.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void AddIncidentsOfCustomers(Incident incident)
        {
            customerIncidents.Add(incident);
        }
        /// <summary>
        /// Clears the incidents of customers.
        /// </summary>
        public void ClearIncidentsOfCustomers()
        {
            customerIncidents.Clear();
        }
        /// <summary>
        /// Size of customers incidents.
        /// </summary>
        /// <returns></returns>
        public int SizeOfCustomersIncidents()
        {
            return customerIncidents.Count;
        }

    }
}
