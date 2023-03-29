using TechSupport.Controller;

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

            foreach (string customerName in _controller.GetCustomerNames())
            {
                customerComboBox.Items.Add(customerName);
            }
            foreach (string productName in _controller.GetProductNames())
            {
                productComboBox.Items.Add(productName);
            }
            customerComboBox.SelectedIndex = 0;
            productComboBox.SelectedIndex = 0;

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
                    throw new ArgumentException("Title and Description is empty");
                }

                if (string.IsNullOrEmpty(title))
                {
                    titleErrorLabel.Text = "Title cannot be empty!";
                    titleErrorLabel.ForeColor = Color.Red;
                    titleErrorLabel.Visible = true;
                    throw new ArgumentException("Title is empty");

                }

                if (string.IsNullOrEmpty(description))
                {
                    descriptionErrorLabel.Text = "Description cannot be empty!";
                    descriptionErrorLabel.ForeColor = Color.Red;
                    descriptionErrorLabel.Visible = true;
                    throw new ArgumentException("Description is empty");
                }

                var customerName = customerComboBox.SelectedItem.ToString();
                var productName = productComboBox.SelectedItem.ToString();

                if (_controller.CheckRegisteredOrNot(customerName, productName))
                {
                    _controller.AddIncident(customerName, productName, title, description);
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
            catch (Exception)
            {

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
