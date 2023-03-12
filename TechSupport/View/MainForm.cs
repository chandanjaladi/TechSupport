using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;

        public MainForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            username.Text = _incidentController.GetUsername();
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            var addIncident = new AddIncidentForm();
            var result = addIncident.ShowDialog();
            if (result == DialogResult.OK)
            {
                incidentsDataGridView.DataSource = null;
                incidentsDataGridView.DataSource = _incidentController.GetIncidents();
            }
        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            var searchIncident = new SearchIncidentForm();
            searchIncident.ShowDialog();
        }

        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
