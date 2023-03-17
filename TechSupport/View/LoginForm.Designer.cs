namespace TechSupport
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            loginButton = new Button();
            passwordMaskedTextBox = new MaskedTextBox();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 62);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 109);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(197, 59);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(154, 170);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // passwordMaskedTextBox
            // 
            passwordMaskedTextBox.Location = new Point(197, 106);
            passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            passwordMaskedTextBox.PasswordChar = '*';
            passwordMaskedTextBox.Size = new Size(100, 23);
            passwordMaskedTextBox.TabIndex = 4;
            passwordMaskedTextBox.UseSystemPasswordChar = true;
            passwordMaskedTextBox.MaskInputRejected += PasswordMaskedTextBox_MaskInputRejected;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(112, 147);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(32, 15);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "Error";
            errorLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 264);
            Controls.Add(errorLabel);
            Controls.Add(passwordMaskedTextBox);
            Controls.Add(loginButton);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private Button loginButton;
        private MaskedTextBox passwordMaskedTextBox;
        private Label errorLabel;
    }
}