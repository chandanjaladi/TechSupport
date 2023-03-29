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
        }
        

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
            
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            customerErrorLabel.Visible = false;
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            if (string.IsNullOrEmpty(title))
            {
                titleErrorLabel.Text = "Title cannot be empty!";
                titleErrorLabel.ForeColor = Color.Red;
                titleErrorLabel.Visible = true;
            }

            if (string.IsNullOrEmpty(description))
            {
                descriptionErrorLabel.Text = "Description cannot be empty!";
                descriptionErrorLabel.ForeColor = Color.Red;
                descriptionErrorLabel.Visible = true;
            }
            try
            {
                int customerId = Convert.ToInt32(customerIDTextBox.Text);
                var incident = new Incident
                {
                    Title = title,
                    Description = description,
                    CustomerID = customerId
                };
                _controller.Add(incident);
                ClearFields();
                customerErrorLabel.Visible = true;
                customerErrorLabel.ForeColor = Color.Green;
                customerErrorLabel.Text = "Incident added sucessfully!";
            }
            catch (FormatException)
            {
                customerErrorLabel.Text = "CustomerID is invalid";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Title cannot be empty!")
                {
                    titleErrorLabel.Visible = true;
                }
                else if (ex.Message == "Description cannot be empty!")
                {
                    descriptionErrorLabel.Visible = true;
                }
                else
                {
                    customerErrorLabel.Text = ex.Message;
                    customerErrorLabel.ForeColor = Color.Red;
                    customerErrorLabel.Visible = true;
                }

            }
        }

        private void ClearFields()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            customerIDTextBox.Clear();
        }
    }
}
