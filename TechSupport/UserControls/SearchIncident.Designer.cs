namespace TechSupport.UserControls
{
    partial class SearchIncident
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
            errorLabel = new Label();
            customersIncidentsDataGridView = new DataGridView();
            searchButton = new Button();
            customerIDTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)customersIncidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(146, 64);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 9;
            errorLabel.Text = "label2";
            errorLabel.Visible = false;
            // 
            // customersIncidentsDataGridView
            // 
            customersIncidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersIncidentsDataGridView.Dock = DockStyle.Bottom;
            customersIncidentsDataGridView.Location = new Point(0, 101);
            customersIncidentsDataGridView.Name = "customersIncidentsDataGridView";
            customersIncidentsDataGridView.RowHeadersWidth = 51;
            customersIncidentsDataGridView.RowTemplate.Height = 25;
            customersIncidentsDataGridView.Size = new Size(530, 191);
            customersIncidentsDataGridView.TabIndex = 8;
            customersIncidentsDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(332, 25);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(146, 26);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(140, 23);
            customerIDTextBox.TabIndex = 6;
            customerIDTextBox.TextChanged += CustomerIDTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 5;
            label1.Text = "CustomerID:";
            // 
            // SearchIncident
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(errorLabel);
            Controls.Add(customersIncidentsDataGridView);
            Controls.Add(searchButton);
            Controls.Add(customerIDTextBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchIncident";
            Size = new Size(530, 292);
            ((System.ComponentModel.ISupportInitialize)customersIncidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private DataGridView customersIncidentsDataGridView;
        private Button searchButton;
        private TextBox customerIDTextBox;
        private Label label1;
    }
}
