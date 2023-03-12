namespace TechSupport.View
{
    partial class MainForm
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
            username = new Label();
            logoutLabel = new LinkLabel();
            addIncidentButton = new Button();
            searchIncidentButton = new Button();
            incidentsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)incidentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(509, 9);
            username.Name = "username";
            username.Size = new Size(30, 15);
            username.TabIndex = 0;
            username.Text = "Jane";
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Location = new Point(502, 24);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(45, 15);
            logoutLabel.TabIndex = 1;
            logoutLabel.TabStop = true;
            logoutLabel.Text = "Logout";
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(139, 66);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(101, 34);
            addIncidentButton.TabIndex = 2;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += addIncidentButton_Click;
            // 
            // searchIncidentButton
            // 
            searchIncidentButton.Location = new Point(302, 66);
            searchIncidentButton.Name = "searchIncidentButton";
            searchIncidentButton.Size = new Size(101, 34);
            searchIncidentButton.TabIndex = 3;
            searchIncidentButton.Text = "Search Incident";
            searchIncidentButton.UseVisualStyleBackColor = true;
            searchIncidentButton.Click += searchIncidentButton_Click;
            // 
            // incidentsDataGridView
            // 
            incidentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentsDataGridView.Location = new Point(12, 125);
            incidentsDataGridView.Name = "incidentsDataGridView";
            incidentsDataGridView.RowTemplate.Height = 25;
            incidentsDataGridView.Size = new Size(527, 150);
            incidentsDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 287);
            Controls.Add(incidentsDataGridView);
            Controls.Add(searchIncidentButton);
            Controls.Add(addIncidentButton);
            Controls.Add(logoutLabel);
            Controls.Add(username);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tech Support";
            ((System.ComponentModel.ISupportInitialize)incidentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private LinkLabel logoutLabel;
        private Button addIncidentButton;
        private Button searchIncidentButton;
        private DataGridView incidentsDataGridView;
    }
}