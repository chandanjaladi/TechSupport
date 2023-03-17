﻿using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainDashboard : Form
    {
        private IncidentController _incidentController;
        public MainDashboard()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            username.Text = _incidentController.GetUsername();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == displayIncident)
            {
                displayIncident1.RefreshIncidents();
            }
        }

    }
}