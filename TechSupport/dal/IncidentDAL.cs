using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {
        private static readonly List<Incident> s_incidents = new List<Incident>();

        public void Add(Incident incident)
        {
            s_incidents.Add(incident);
        }

        public List<Incident> GetIncidents()
        {
            return s_incidents;
        }


    }
}
