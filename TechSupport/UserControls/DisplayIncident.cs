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
            if (_incidentController.GetIncidents().Count != 0)
            {
                incidentsDataGridView.DataSource = _incidentController.GetIncidents();
            }
        }

        public void RefreshIncidents()
        {
            incidentsDataGridView.DataSource = null;
            incidentsDataGridView.DataSource = _incidentController.GetIncidents();
        }
    }
}
