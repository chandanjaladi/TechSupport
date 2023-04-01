namespace TechSupport.View
{
    partial class MainDashboard
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
            tabControl1 = new TabControl();
            addIncidentsTabPage = new TabPage();
            addIncident1 = new UserControl.AddIncidentUserControl();
            openIncidentsTabPage = new TabPage();
            openIncidents1 = new UserControls.OpenIncidentsUserControl();
            updateIncidentsTabPage = new TabPage();
            updateIncidentUserControl1 = new UserControls.UpdateIncidentUserControl();
            logoutLabel = new LinkLabel();
            username = new Label();
            informationLabel = new Label();
            tabControl1.SuspendLayout();
            addIncidentsTabPage.SuspendLayout();
            openIncidentsTabPage.SuspendLayout();
            updateIncidentsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addIncidentsTabPage);
            tabControl1.Controls.Add(openIncidentsTabPage);
            tabControl1.Controls.Add(updateIncidentsTabPage);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 545);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // addIncidentsTabPage
            // 
            addIncidentsTabPage.Controls.Add(addIncident1);
            addIncidentsTabPage.Location = new Point(4, 24);
            addIncidentsTabPage.Margin = new Padding(3, 2, 3, 2);
            addIncidentsTabPage.Name = "addIncidentsTabPage";
            addIncidentsTabPage.Padding = new Padding(3, 2, 3, 2);
            addIncidentsTabPage.Size = new Size(692, 390);
            addIncidentsTabPage.TabIndex = 0;
            addIncidentsTabPage.Text = "Add Incident";
            addIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncident1
            // 
            addIncident1.Location = new Point(116, -8);
            addIncident1.Margin = new Padding(3, 2, 3, 2);
            addIncident1.Name = "addIncident1";
            addIncident1.Size = new Size(506, 419);
            addIncident1.TabIndex = 0;
            // 
            // openIncidentsTabPage
            // 
            openIncidentsTabPage.Controls.Add(openIncidents1);
            openIncidentsTabPage.Location = new Point(4, 24);
            openIncidentsTabPage.Name = "openIncidentsTabPage";
            openIncidentsTabPage.Size = new Size(692, 390);
            openIncidentsTabPage.TabIndex = 3;
            openIncidentsTabPage.Text = "Open Incidents";
            openIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // openIncidents1
            // 
            openIncidents1.Dock = DockStyle.Fill;
            openIncidents1.Location = new Point(0, 0);
            openIncidents1.Name = "openIncidents1";
            openIncidents1.Size = new Size(692, 390);
            openIncidents1.TabIndex = 0;
            // 
            // updateIncidentsTabPage
            // 
            updateIncidentsTabPage.Controls.Add(updateIncidentUserControl1);
            updateIncidentsTabPage.Location = new Point(4, 24);
            updateIncidentsTabPage.Name = "updateIncidentsTabPage";
            updateIncidentsTabPage.Size = new Size(692, 517);
            updateIncidentsTabPage.TabIndex = 4;
            updateIncidentsTabPage.Text = "Update Incident";
            updateIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            updateIncidentUserControl1.Location = new Point(43, -2);
            updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            updateIncidentUserControl1.Size = new Size(613, 511);
            updateIncidentUserControl1.TabIndex = 0;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Location = new Point(640, 21);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(45, 15);
            logoutLabel.TabIndex = 3;
            logoutLabel.TabStop = true;
            logoutLabel.Text = "Logout";
            logoutLabel.LinkClicked += logoutLabel_LinkClicked;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(632, 6);
            username.Name = "username";
            username.Size = new Size(59, 15);
            username.TabIndex = 2;
            username.Text = "username";
            // 
            // informationLabel
            // 
            informationLabel.AutoSize = true;
            informationLabel.Location = new Point(63, 9);
            informationLabel.Name = "informationLabel";
            informationLabel.Size = new Size(38, 15);
            informationLabel.TabIndex = 4;
            informationLabel.Text = "label1";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 583);
            Controls.Add(informationLabel);
            Controls.Add(logoutLabel);
            Controls.Add(username);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            tabControl1.ResumeLayout(false);
            addIncidentsTabPage.ResumeLayout(false);
            openIncidentsTabPage.ResumeLayout(false);
            updateIncidentsTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage addIncidentsTabPage;
        private LinkLabel logoutLabel;
        private Label username;
        private UserControl.AddIncidentUserControl addIncident1;
        private TabPage openIncidentsTabPage;
        private UserControls.OpenIncidentsUserControl openIncidents1;
        private Label informationLabel;
        private TabPage updateIncidentsTabPage;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
    }
}