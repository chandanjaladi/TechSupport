using TechSupport.Controller;
using TechSupport.View;

namespace TechSupport
{
    public partial class LoginForm : Form
    {
        private IncidentController _incidentController;
        public LoginForm()
        {
            InitializeComponent();
            _incidentController = new IncidentController();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            var username = _incidentController.GetUsername();
            var password = _incidentController.GetPassword();
            if (username == usernameTextBox.Text && password == passwordMaskedTextBox.Text)
            {
                var mainform = new MainForm();
                mainform.ShowDialog();
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

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void passwordMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}