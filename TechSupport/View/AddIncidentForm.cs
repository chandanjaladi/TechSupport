using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{

    /// <summary>
    /// This class is used to add incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddIncidentForm : Form
    {
        private IncidentController _controller;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public AddIncidentForm()
        {
            InitializeComponent();
            _controller = new IncidentController();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
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
            if (title.Equals(""))
            {
                titleErrorLabel.Text = "Title cannot be empty!";
                titleErrorLabel.ForeColor = Color.Red;
                titleErrorLabel.Visible = true;
            }

            if (description.Equals(""))
            {
                descriptionErrorLabel.Text = "Description cannot be empty";
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
                DialogResult = DialogResult.OK;
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
