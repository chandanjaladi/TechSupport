﻿namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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
            label1 = new Label();
            incidentErrorLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            incidentTextBox = new TextBox();
            customerTextBox = new TextBox();
            productTextBox = new TextBox();
            titleTextBox = new TextBox();
            dateOpenedTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            textToAddTextBox = new TextBox();
            technicianComboBox = new ComboBox();
            getIncident = new Button();
            updateButton = new Button();
            closeButton = new Button();
            clearButton = new Button();
            updateErrorLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Incident ID:";
            // 
            // incidentErrorLabel
            // 
            incidentErrorLabel.AutoSize = true;
            incidentErrorLabel.Location = new Point(102, 62);
            incidentErrorLabel.Name = "incidentErrorLabel";
            incidentErrorLabel.Size = new Size(103, 15);
            incidentErrorLabel.TabIndex = 1;
            incidentErrorLabel.Text = "incidentErrorLabel";
            incidentErrorLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 131);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Product:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 168);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Technician:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 208);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 5;
            label5.Text = "Title:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 248);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 6;
            label6.Text = "Date Opened:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 289);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 7;
            label7.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 378);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 8;
            label8.Text = "Text To Add:";
            // 
            // incidentTextBox
            // 
            incidentTextBox.Location = new Point(133, 29);
            incidentTextBox.Name = "incidentTextBox";
            incidentTextBox.Size = new Size(121, 23);
            incidentTextBox.TabIndex = 9;
            incidentTextBox.KeyPress += incidentTextBox_KeyPress;
            // 
            // customerTextBox
            // 
            customerTextBox.Location = new Point(133, 89);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.ReadOnly = true;
            customerTextBox.Size = new Size(230, 23);
            customerTextBox.TabIndex = 10;
            // 
            // productTextBox
            // 
            productTextBox.Location = new Point(133, 128);
            productTextBox.Name = "productTextBox";
            productTextBox.ReadOnly = true;
            productTextBox.Size = new Size(230, 23);
            productTextBox.TabIndex = 11;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(133, 205);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(230, 23);
            titleTextBox.TabIndex = 12;
            // 
            // dateOpenedTextBox
            // 
            dateOpenedTextBox.Location = new Point(133, 245);
            dateOpenedTextBox.Name = "dateOpenedTextBox";
            dateOpenedTextBox.ReadOnly = true;
            dateOpenedTextBox.Size = new Size(230, 23);
            dateOpenedTextBox.TabIndex = 13;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(133, 286);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(230, 68);
            descriptionTextBox.TabIndex = 18;
            // 
            // textToAddTextBox
            // 
            textToAddTextBox.Enabled = false;
            textToAddTextBox.Location = new Point(133, 378);
            textToAddTextBox.Multiline = true;
            textToAddTextBox.Name = "textToAddTextBox";
            textToAddTextBox.Size = new Size(230, 68);
            textToAddTextBox.TabIndex = 19;
            // 
            // technicianComboBox
            // 
            technicianComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            technicianComboBox.FormattingEnabled = true;
            technicianComboBox.Location = new Point(133, 165);
            technicianComboBox.Name = "technicianComboBox";
            technicianComboBox.Size = new Size(230, 23);
            technicianComboBox.TabIndex = 20;
            // 
            // getIncident
            // 
            getIncident.Location = new Point(322, 28);
            getIncident.Name = "getIncident";
            getIncident.Size = new Size(75, 23);
            getIncident.TabIndex = 21;
            getIncident.Text = "Get";
            getIncident.UseVisualStyleBackColor = true;
            getIncident.Click += getIncident_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new Point(133, 483);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 22;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // closeButton
            // 
            closeButton.Enabled = false;
            closeButton.Location = new Point(224, 483);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 23;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(322, 483);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 24;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // updateErrorLabel
            // 
            updateErrorLabel.AutoSize = true;
            updateErrorLabel.Location = new Point(182, 456);
            updateErrorLabel.Name = "updateErrorLabel";
            updateErrorLabel.Size = new Size(38, 15);
            updateErrorLabel.TabIndex = 25;
            updateErrorLabel.Text = "label9";
            updateErrorLabel.Visible = false;
            // 
            // UpdateIncidentUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updateErrorLabel);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(updateButton);
            Controls.Add(getIncident);
            Controls.Add(technicianComboBox);
            Controls.Add(textToAddTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(dateOpenedTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(productTextBox);
            Controls.Add(customerTextBox);
            Controls.Add(incidentTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(incidentErrorLabel);
            Controls.Add(label1);
            Name = "UpdateIncidentUserControl";
            Size = new Size(613, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label incidentErrorLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox incidentTextBox;
        private TextBox customerTextBox;
        private TextBox productTextBox;
        private TextBox titleTextBox;
        private TextBox dateOpenedTextBox;
        private TextBox descriptionTextBox;
        private TextBox textToAddTextBox;
        private ComboBox technicianComboBox;
        private Button getIncident;
        private Button updateButton;
        private Button closeButton;
        private Button clearButton;
        private Label updateErrorLabel;
    }
}
