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
            addIncident = new TabPage();
            addIncident1 = new UserControl.AddIncident();
            displayIncident = new TabPage();
            displayIncident1 = new UserControls.DisplayIncident();
            searchIncident = new TabPage();
            searchIncident1 = new UserControls.SearchIncident();
            openIncidentsTabPage = new TabPage();
            openIncidents1 = new UserControls.OpenIncidents();
            logoutLabel = new LinkLabel();
            username = new Label();
            informationLabel = new Label();
            tabControl1.SuspendLayout();
            addIncident.SuspendLayout();
            displayIncident.SuspendLayout();
            searchIncident.SuspendLayout();
            openIncidentsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(addIncident);
            tabControl1.Controls.Add(displayIncident);
            tabControl1.Controls.Add(searchIncident);
            tabControl1.Controls.Add(openIncidentsTabPage);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 418);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // addIncident
            // 
            addIncident.Controls.Add(addIncident1);
            addIncident.Location = new Point(4, 24);
            addIncident.Margin = new Padding(3, 2, 3, 2);
            addIncident.Name = "addIncident";
            addIncident.Padding = new Padding(3, 2, 3, 2);
            addIncident.Size = new Size(692, 390);
            addIncident.TabIndex = 0;
            addIncident.Text = "Add Incident";
            addIncident.UseVisualStyleBackColor = true;
            // 
            // addIncident1
            // 
            addIncident1.Location = new Point(116, -8);
            addIncident1.Margin = new Padding(3, 2, 3, 2);
            addIncident1.Name = "addIncident1";
            addIncident1.Size = new Size(506, 419);
            addIncident1.TabIndex = 0;
            // 
            // displayIncident
            // 
            displayIncident.Controls.Add(displayIncident1);
            displayIncident.Location = new Point(4, 24);
            displayIncident.Margin = new Padding(3, 2, 3, 2);
            displayIncident.Name = "displayIncident";
            displayIncident.Padding = new Padding(3, 2, 3, 2);
            displayIncident.Size = new Size(692, 390);
            displayIncident.TabIndex = 1;
            displayIncident.Text = "Display Incident";
            displayIncident.UseVisualStyleBackColor = true;
            // 
            // displayIncident1
            // 
            displayIncident1.Dock = DockStyle.Fill;
            displayIncident1.Location = new Point(3, 2);
            displayIncident1.Margin = new Padding(3, 2, 3, 2);
            displayIncident1.Name = "displayIncident1";
            displayIncident1.Size = new Size(686, 386);
            displayIncident1.TabIndex = 0;
            // 
            // searchIncident
            // 
            searchIncident.Controls.Add(searchIncident1);
            searchIncident.Location = new Point(4, 24);
            searchIncident.Margin = new Padding(3, 2, 3, 2);
            searchIncident.Name = "searchIncident";
            searchIncident.Size = new Size(692, 390);
            searchIncident.TabIndex = 2;
            searchIncident.Text = "Search Incident";
            searchIncident.UseVisualStyleBackColor = true;
            // 
            // searchIncident1
            // 
            searchIncident1.Dock = DockStyle.Fill;
            searchIncident1.Location = new Point(0, 0);
            searchIncident1.Margin = new Padding(3, 2, 3, 2);
            searchIncident1.Name = "searchIncident1";
            searchIncident1.Size = new Size(692, 390);
            searchIncident1.TabIndex = 0;
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
            ClientSize = new Size(700, 456);
            Controls.Add(informationLabel);
            Controls.Add(logoutLabel);
            Controls.Add(username);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            tabControl1.ResumeLayout(false);
            addIncident.ResumeLayout(false);
            displayIncident.ResumeLayout(false);
            searchIncident.ResumeLayout(false);
            openIncidentsTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage addIncident;
        private TabPage displayIncident;
        private TabPage searchIncident;
        private LinkLabel logoutLabel;
        private Label username;
        private UserControl.AddIncident addIncident1;
        private UserControls.DisplayIncident displayIncident1;
        private UserControls.SearchIncident searchIncident1;
        private TabPage openIncidentsTabPage;
        private UserControls.OpenIncidents openIncidents1;
        private Label informationLabel;
    }
}