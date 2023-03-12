using TechSupport.DAL;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL _incidentDal;
        private string _username = "jane";
        private string _password = "test123";

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
    }
}
