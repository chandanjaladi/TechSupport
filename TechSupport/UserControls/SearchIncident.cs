using TechSupport.Controller;

namespace TechSupport.UserControls
{
    public partial class SearchIncident : System.Windows.Forms.UserControl
    {
        public SearchIncident()
        {

            InitializeComponent();
            _controller = new IncidentController();

        }

        private IncidentController _controller;

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        //public SearchIncidentForm()
        //{
        //    InitializeComponent();
        //    _controller = new IncidentController();
        //    _incidentDAL = new IncidentDAL();
        //}

        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {
                var customerID = Convert.ToInt32(customerIDTextBox.Text);
                customersIncidentsDataGridView.Visible = true;
                customersIncidentsDataGridView.DataSource = _controller.specificCustomerIncidents(customerID);

                //if (false)
                //{
                //    errorLabel.Visible = false;
                //    C
                //    RefreshIncidents();
                //}
                //else
                //{
                //    customersIncidentsDataGridView.Visible = false;
                //    errorLabel.Text = "Customer id cannot be found";
                //    errorLabel.ForeColor = Color.Red;
                //    errorLabel.Visible = true;
                //    customerIDTextBox.Clear();
                //}
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
    }
}
