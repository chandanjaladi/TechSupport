using TechSupport.Controller;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class SearchIncidentForm : Form
    {
        private IncidentController _controller;
        private IncidentDAL _incidentDAL;
        public SearchIncidentForm()
        {
            InitializeComponent();
            _controller = new IncidentController();
            _incidentDAL = new IncidentDAL();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _incidentDAL.ClearIncidentsOfCustomers();
            try
            {
                var customerID = Convert.ToInt32(customerIDTextBox.Text);
                foreach (Incident incident in _controller.GetIncidents())
                {
                    if (customerID == incident.CustomerID)
                    {
                        _incidentDAL.AddIncidentsOfCustomers(incident);
                    }
                }
                int count = _incidentDAL.SizeOfCustomersIncidents();
                if (count != 0)
                {
                    errorLabel.Visible = false;
                    customersIncidentsDataGridView.Visible = true;
                    customersIncidentsDataGridView.DataSource = null;
                    customersIncidentsDataGridView.DataSource = _incidentDAL.GetCustomerIncidents();
                }
                else
                {
                    customersIncidentsDataGridView.Visible = false;
                    errorLabel.Text = "Customer id cannot be found";
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Visible = true;
                    customerIDTextBox.Clear();
                }
            }
            catch (FormatException)
            {
                errorLabel.Text = "Enter a valid customer id";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                customerIDTextBox.Clear();
            }
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
