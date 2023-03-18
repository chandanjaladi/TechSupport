using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This is the class for display incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class DisplayIncident : System.Windows.Forms.UserControl
    {
        private IncidentController _incidentController;
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayIncident"/> class.
        /// </summary>
        public DisplayIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            
        }
        /// <summary>
        /// Refreshes the incidents.
        /// </summary>
        /// <returns></returns>
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
