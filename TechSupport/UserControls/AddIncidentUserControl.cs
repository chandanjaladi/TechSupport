using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControl
{
    /// <summary>
    /// Class for add incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AddIncidentUserControl : System.Windows.Forms.UserControl
    {
        private IncidentController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentUserControl"/> class.
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            _controller = new IncidentController();
            customerComboBox.DataSource = _controller.GetCustomerNames();
            productComboBox.DataSource = _controller.GetProductNames();
        }


        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
            customerErrorLabel.Visible = false;

        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
            customerErrorLabel.Visible = false;
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            customerErrorLabel.Visible = false;
            try
            {

                string title = titleTextBox.Text;
                string description = descriptionTextBox.Text;

                if (string.IsNullOrEmpty(title) && string.IsNullOrEmpty(description))
                {
                    titleErrorLabel.Text = "Title cannot be empty!";
                    titleErrorLabel.ForeColor = Color.Red;
                    titleErrorLabel.Visible = true;
                    descriptionErrorLabel.Text = "Description cannot be empty!";
                    descriptionErrorLabel.ForeColor = Color.Red;
                    descriptionErrorLabel.Visible = true;
                }
                var customerName = customerComboBox.SelectedItem.ToString();
                var productName = productComboBox.SelectedItem.ToString();
                var customerID = _controller.GetCustomerID(customerName);
                var productCode = _controller.GetProductCode(productName);
                
                if (_controller.CheckRegisteredOrNot(customerID, productCode))
                {
                    var incident = new Incident
                    {
                        CustomerID = customerID,
                        ProductCode = productCode,
                        Title = title,
                        Description = description
                    };
                    _controller.AddIncident(incident);
                    ClearFields();
                    customerErrorLabel.Visible = true;
                    customerErrorLabel.ForeColor = Color.Green;
                    customerErrorLabel.Text = "Incident added sucessfully!";
                }
                else
                {
                    customerErrorLabel.Visible = true;
                    customerErrorLabel.ForeColor = Color.Red;
                    customerErrorLabel.Text = "Selected Customer is not registered with selected Product";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Title cannot be empty!")
                {
                    titleErrorLabel.Text = "Title cannot be empty!";
                    titleErrorLabel.ForeColor = Color.Red;
                    titleErrorLabel.Visible = true;
                }
                if (ex.Message == "Description cannot be empty!")
                {
                    descriptionErrorLabel.Text = "Description cannot be empty!";
                    descriptionErrorLabel.ForeColor = Color.Red;
                    descriptionErrorLabel.Visible = true;
                }
            }
        }

        private void ClearFields()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            customerComboBox.SelectedIndex = 0;
            productComboBox.SelectedIndex = 0;
        }
    }
}
