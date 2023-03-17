using TechSupport.Controller;

namespace TechSupport.View
{

    /// <summary>
    /// This class is used for main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            username.Text = _incidentController.GetUsername();
            if (_incidentController.GetIncidents().Count != 0)
            {
                incidentsDataGridView.DataSource = _incidentController.GetIncidents();
            }
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            var addIncident = new AddIncidentForm();
            var result = addIncident.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshIncidents();
            }
        }

        public void RefreshIncidents()
        {
            incidentsDataGridView.DataSource = null;
            incidentsDataGridView.DataSource = _incidentController.GetIncidents();
        }

        /// <summary>
        /// Sets the controller.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public void SetController(IncidentController controller)
        {
            _incidentController = controller;
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            var searchIncident = new SearchIncidentForm();
            searchIncident.ShowDialog();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            //var login = new LoginForm();
            //login.setIncidentController(_incidentController);
            //login.Show();
            DialogResult = DialogResult.OK;
        }
    }
}
