using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class SearchIncident : System.Windows.Forms.UserControl
    {
        private IncidentController _controller;
        public SearchIncident()
        {
            InitializeComponent();
            _controller = new IncidentController();
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            try
            {
                var customerID = Int32.Parse(customerIDTextBox.Text);
                customersIncidentsDataGridView.Visible = true;
                if (_controller.specificCustomerIncidents(customerID).Count != 0)
                {
                    customersIncidentsDataGridView.DataSource = _controller.specificCustomerIncidents(customerID);
                }
                else
                {
                    customersIncidentsDataGridView.Visible = false;
                    label2.Text = "No customers found for the given customerID";
                    label2.ForeColor = Color.Red;
                    label2.Visible = true;
                    customerIDTextBox.Clear();
                }
            }
            catch (FormatException)
            {
                customersIncidentsDataGridView.Visible = false;
                errorLabel.Text = "Enter a valid customer id";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                customerIDTextBox.Clear();
            }
        }

        public void RefreshIncidents()
        {
            customersIncidentsDataGridView.Visible = true;
            customersIncidentsDataGridView.DataSource = null;
        }

        public void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void customerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = "Please enter the customer number (only numbers are allowed)";
            label2.Visible = true;
            label2.ForeColor = Color.Black;
            customersIncidentsDataGridView.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
