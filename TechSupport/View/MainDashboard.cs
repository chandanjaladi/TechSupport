using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// This class is main dashboard
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        private IncidentController _incidentController;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            username.Text = _incidentController.GetUsername();
            informationLabel.Text = "Fill the detials and add an incident";

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == addIncident)
            {
                informationLabel.Text = "Fill the detials and add an incident";
            }

            if (tabControl1.SelectedTab == displayIncident)
            {
                var condition = displayIncident1.RefreshIncidents();
                if (!condition)
                {
                    informationLabel.Text = "No incidents added to display";
                }
                else
                {
                    informationLabel.Text = "All incidents are displayed below";
                }

            }
            if (tabControl1.SelectedTab == openIncidentsTabPage)
            {
                informationLabel.Text = "All incidents linked with database are displayed below";
                openIncidents1.displayOpenIncidents();
            }
            if (tabControl1.SelectedTab == searchIncident)
            {
                informationLabel.Text = "Enter customer ID to get their incidents";
            }
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
