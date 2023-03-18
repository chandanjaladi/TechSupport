using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{

    /// <summary>
    /// This class is used for searching incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchIncidentForm : Form
    {
        private IncidentController _controller;
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public SearchIncidentForm()
        {
            InitializeComponent();
            _controller = new IncidentController();
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var customerID = Convert.ToInt32(customerIDTextBox.Text);
                foreach (Incident incident in _controller.GetIncidents())
                {
                    if (customerID == incident.CustomerID)
                    {
                       
                    }
                }
                //int count = _incidentDAL.SizeOfCustomersIncidents();
                //if (count != 0)
                //{
                //    errorLabel.Visible = false;
                //    customersIncidentsDataGridView.Visible = true;
                //    customersIncidentsDataGridView.DataSource = null;
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
