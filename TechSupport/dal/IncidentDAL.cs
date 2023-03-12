using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static readonly List<Incident> s_incidents = new List<Incident>();
        private List<Incident> customerIncidents = new List<Incident>();

        public void Add(Incident incident)
        {
            s_incidents.Add(incident);
        }

        public List<Incident> GetIncidents()
        {
            return s_incidents;
        }

        public List<Incident> GetCustomerIncidents() 
        { 
            return customerIncidents;
        }

        public void AddIncidentsOfCustomers(Incident incident) 
        {
            customerIncidents.Add(incident);
        }

        public void ClearIncidentsOfCustomers()
        {
            customerIncidents.Clear();
        }

        public int SizeOfCustomersIncidents() 
        {
            return customerIncidents.Count;
        }

    }
}
