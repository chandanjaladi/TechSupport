namespace TechSupport.UserControl
{
    partial class AddIncidentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelButton = new Button();
            customerErrorLabel = new Label();
            descriptionErrorLabel = new Label();
            titleErrorLabel = new Label();
            addIncidentButton = new Button();
            descriptionTextBox = new TextBox();
            titleTextBox = new TextBox();
            customerLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            customerComboBox = new ComboBox();
            productLabel = new Label();
            productComboBox = new ComboBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(201, 358);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(92, 28);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Clear";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // customerErrorLabel
            // 
            customerErrorLabel.AutoSize = true;
            customerErrorLabel.Location = new Point(48, 37);
            customerErrorLabel.Name = "customerErrorLabel";
            customerErrorLabel.Size = new Size(310, 15);
            customerErrorLabel.TabIndex = 22;
            customerErrorLabel.Text = "Selected Customer is not registered with selected Product";
            customerErrorLabel.Visible = false;
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.Location = new Point(136, 320);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(95, 15);
            descriptionErrorLabel.TabIndex = 21;
            descriptionErrorLabel.Text = "Descritpion Error";
            descriptionErrorLabel.Visible = false;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.Location = new Point(136, 226);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(57, 15);
            titleErrorLabel.TabIndex = 20;
            titleErrorLabel.Text = "Title Error";
            titleErrorLabel.Visible = false;
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(84, 358);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(92, 28);
            addIncidentButton.TabIndex = 19;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += AddIncidentButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(182, 248);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(138, 68);
            descriptionTextBox.TabIndex = 17;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(182, 200);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(138, 23);
            titleTextBox.TabIndex = 16;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new Point(87, 114);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(62, 15);
            customerLabel.TabIndex = 15;
            customerLabel.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 251);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 202);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 13;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 62);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 12;
            label1.Text = "Add Incident Detials";
            // 
            // customerComboBox
            // 
            customerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(182, 111);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(138, 23);
            customerComboBox.TabIndex = 24;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Location = new Point(87, 158);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(52, 15);
            productLabel.TabIndex = 25;
            productLabel.Text = "Product:";
            // 
            // productComboBox
            // 
            productComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(182, 155);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(138, 23);
            productComboBox.TabIndex = 26;
            // 
            // AddIncidentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productComboBox);
            Controls.Add(productLabel);
            Controls.Add(customerComboBox);
            Controls.Add(cancelButton);
            Controls.Add(customerErrorLabel);
            Controls.Add(descriptionErrorLabel);
            Controls.Add(titleErrorLabel);
            Controls.Add(addIncidentButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(customerLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddIncidentUserControl";
            Size = new Size(404, 417);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Label customerErrorLabel;
        private Label descriptionErrorLabel;
        private Label titleErrorLabel;
        private Button addIncidentButton;
        private TextBox customerIDTextBox;
        private TextBox descriptionTextBox;
        private TextBox titleTextBox;
        private Label customerLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox customerComboBox;
        private Label productLabel;
        private ComboBox productComboBox;
    }
}
