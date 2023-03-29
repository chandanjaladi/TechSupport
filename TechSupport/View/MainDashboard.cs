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

            if (tabControl1.SelectedTab == openIncidentsTabPage)
            {
                try
                {
                    informationLabel.Text = "All incidents linked with database are displayed below";
                    openIncidents1.displayOpenIncidents();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please connect to Database");
                }
            }
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
