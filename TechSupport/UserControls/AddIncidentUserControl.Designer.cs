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
            customerIDTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            titleTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(190, 328);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(92, 28);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // customerErrorLabel
            // 
            customerErrorLabel.AutoSize = true;
            customerErrorLabel.Location = new Point(136, 284);
            customerErrorLabel.Name = "customerErrorLabel";
            customerErrorLabel.Size = new Size(98, 15);
            customerErrorLabel.TabIndex = 22;
            customerErrorLabel.Text = "CustomerID Error";
            customerErrorLabel.Visible = false;
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.Location = new Point(136, 230);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(95, 15);
            descriptionErrorLabel.TabIndex = 21;
            descriptionErrorLabel.Text = "Descritpion Error";
            descriptionErrorLabel.Visible = false;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.Location = new Point(136, 136);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(57, 15);
            titleErrorLabel.TabIndex = 20;
            titleErrorLabel.Text = "Title Error";
            titleErrorLabel.Visible = false;
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(85, 328);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(92, 28);
            addIncidentButton.TabIndex = 19;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += AddIncidentButton_Click;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(182, 259);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(138, 23);
            customerIDTextBox.TabIndex = 18;
            customerIDTextBox.TextChanged += CustomerIDTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(182, 158);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(138, 68);
            descriptionTextBox.TabIndex = 17;
            descriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(182, 110);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(138, 23);
            titleTextBox.TabIndex = 16;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 262);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 15;
            label4.Text = "CustomerID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 161);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 14;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 112);
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
            // AddIncident
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelButton);
            Controls.Add(customerErrorLabel);
            Controls.Add(descriptionErrorLabel);
            Controls.Add(titleErrorLabel);
            Controls.Add(addIncidentButton);
            Controls.Add(customerIDTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddIncident";
            Size = new Size(404, 417);
            Click += AddIncidentButton_Click;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
