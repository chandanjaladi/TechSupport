using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControl
{
    /// <summary>
    /// Class for add incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AddIncident : System.Windows.Forms.UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncident"/> class.
        /// </summary>
        public AddIncident()
        {
            InitializeComponent();
            _controller = new IncidentController();
        }
        private IncidentController _controller;

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
            customerErrorLabel.Visible = false;
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
            if (title.Equals("") || title == null)
            {
                titleErrorLabel.Text = "Title cannot be empty!";
                titleErrorLabel.ForeColor = Color.Red;
                titleErrorLabel.Visible = true;
            }

            if (description.Equals("") || description == null)
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
                titleTextBox.Clear();
                descriptionTextBox.Clear();
                customerIDTextBox.Clear();
                customerErrorLabel.Visible = true;
                customerErrorLabel.ForeColor = Color.Green;
                customerErrorLabel.Text = "Incident added sucessfully!";
            }
            catch (ArgumentException ex)
            {
                customerErrorLabel.Text = ex.Message;
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (FormatException)
            {
                customerErrorLabel.Text = "CustomerID is invalid";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (Exception)
            {
                
            }
        }
    }
}
