using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class DisplayIncident : System.Windows.Forms.UserControl
    {
        private IncidentController _incidentController;
        public DisplayIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            
        }

        public bool RefreshIncidents()
        {
            if (_incidentController.GetIncidents().Count == 0)
            {
                incidentsDataGridView.Visible = false;
                return false;
            }
            else
            {
                incidentsDataGridView.Visible = true;
                incidentsDataGridView.DataSource = null;
                incidentsDataGridView.DataSource = _incidentController.GetIncidents();
                return true;
            }
        }
    }
}
