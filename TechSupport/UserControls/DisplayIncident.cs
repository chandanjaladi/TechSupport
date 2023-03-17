using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechSupport.UserControls
{
    public partial class DisplayIncident : System.Windows.Forms.UserControl
    {
        private IncidentController _incidentController;
        public DisplayIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
            if (_incidentController.GetIncidents().Count != 0)
            {
                incidentsDataGridView.DataSource = _incidentController.GetIncidents();
            }
        }

        public void RefreshIncidents()
        {
            incidentsDataGridView.DataSource = null;
            incidentsDataGridView.DataSource = _incidentController.GetIncidents();
        }
    }
}
