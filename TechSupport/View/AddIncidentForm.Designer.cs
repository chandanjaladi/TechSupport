namespace TechSupport.View
{
    partial class AddIncidentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            customerIDTextBox = new TextBox();
            addIncidentButton = new Button();
            titleErrorLabel = new Label();
            descriptionErrorLabel = new Label();
            customerErrorLabel = new Label();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 21);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Incident Detials";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 72);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 221);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "CustomerID:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(160, 69);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(138, 23);
            titleTextBox.TabIndex = 4;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(160, 118);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(138, 68);
            descriptionTextBox.TabIndex = 5;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(160, 218);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(138, 23);
            customerIDTextBox.TabIndex = 6;
            customerIDTextBox.TextChanged += customerIDTextBox_TextChanged;
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(63, 288);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(92, 28);
            addIncidentButton.TabIndex = 7;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += addIncidentButton_Click;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.Location = new Point(160, 95);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(57, 15);
            titleErrorLabel.TabIndex = 8;
            titleErrorLabel.Text = "Title Error";
            titleErrorLabel.Visible = false;
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.Location = new Point(160, 189);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(95, 15);
            descriptionErrorLabel.TabIndex = 9;
            descriptionErrorLabel.Text = "Descritpion Error";
            descriptionErrorLabel.Visible = false;
            // 
            // customerErrorLabel
            // 
            customerErrorLabel.AutoSize = true;
            customerErrorLabel.Location = new Point(160, 244);
            customerErrorLabel.Name = "customerErrorLabel";
            customerErrorLabel.Size = new Size(98, 15);
            customerErrorLabel.TabIndex = 10;
            customerErrorLabel.Text = "CustomerID Error";
            customerErrorLabel.Visible = false;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(168, 288);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(92, 28);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddIncidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 336);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddIncidentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Incident";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private TextBox customerIDTextBox;
        private Button addIncidentButton;
        private Label titleErrorLabel;
        private Label descriptionErrorLabel;
        private Label customerErrorLabel;
        private Button cancelButton;
    }
}