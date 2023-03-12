namespace TechSupport.View
{
    partial class SearchIncidentForm
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
            customerIDTextBox = new TextBox();
            searchButton = new Button();
            customersIncidentsDataGridView = new DataGridView();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)customersIncidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "CustomerID:";
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(138, 49);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(140, 23);
            customerIDTextBox.TabIndex = 1;
            customerIDTextBox.TextChanged += CustomerIDTextBox_TextChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(325, 48);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // customersIncidentsDataGridView
            // 
            customersIncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersIncidentsDataGridView.Location = new Point(12, 125);
            customersIncidentsDataGridView.Name = "customersIncidentsDataGridView";
            customersIncidentsDataGridView.RowTemplate.Height = 25;
            customersIncidentsDataGridView.Size = new Size(473, 150);
            customersIncidentsDataGridView.TabIndex = 3;
            customersIncidentsDataGridView.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(138, 87);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "label2";
            errorLabel.Visible = false;
            // 
            // SearchIncidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 287);
            Controls.Add(errorLabel);
            Controls.Add(customersIncidentsDataGridView);
            Controls.Add(searchButton);
            Controls.Add(customerIDTextBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchIncidentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Incident";
            ((System.ComponentModel.ISupportInitialize)customersIncidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerIDTextBox;
        private Button searchButton;
        private DataGridView customersIncidentsDataGridView;
        private Label errorLabel;
    }
}