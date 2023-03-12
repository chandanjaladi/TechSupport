using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL _incidentDal;
        private string _username = "jane";
        private string _password = "test1234";

        public IncidentController()
        {
            _incidentDal = new IncidentDAL();
        }
        public string GetUsername()
        {
            return _username;
        }

        public string GetPassword()
        {
            return _password;
        }

        public List<Incident> GetIncidents()
        {
            return _incidentDal.GetIncidents();
        }

        public void Add(Incident incident)
        {
            _incidentDal.Add(incident);
        }
    }
}
