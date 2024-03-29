using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport
{

    /// <summary>
    /// This class is used for login form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        private IncidentController _incidentController;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            var username = _incidentController.GetUsername();
            var password = _incidentController.GetPassword();
            if (username == usernameTextBox.Text && password == passwordMaskedTextBox.Text)
            {
                using var mainform = new MainDashboard();
                this.Hide();
                var value = mainform.ShowDialog();
                if (value != DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }

                usernameTextBox.Clear();
                passwordMaskedTextBox.Clear();

            }
            else
            {
                usernameTextBox.Clear();
                passwordMaskedTextBox.Clear();
                errorLabel.Text = "Invalid Username or Password";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void PasswordMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}