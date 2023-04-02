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

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : System.Windows.Forms.UserControl
    {
        private IncidentController _controller;
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _controller = new IncidentController();
            technicianComboBox.DataSource = _controller.GetTechniciansNames();
        }



        private void incidentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            incidentTextBox.Clear();
            customerTextBox.Clear();
            productTextBox.Clear();
            titleTextBox.Clear();
            dateOpenedTextBox.Clear();
            descriptionTextBox.Clear();
            textToAddTextBox.Clear();

        }

        private void getIncident_Click(object sender, EventArgs e)
        {
            incidentErrorLabel.Visible = false;
            int incidentID = Convert.ToInt32(incidentTextBox.Text);
            var myIncident = _controller.GetParticularIncident(incidentID);
            if (myIncident!= null)
            {
                customerTextBox.Text = myIncident.CustomerName;
                productTextBox.Text = myIncident.ProductCode;
                titleTextBox.Text = myIncident.Title;
                descriptionTextBox.Text = myIncident.Description;
                dateOpenedTextBox.Text = myIncident.OpenedDate.ToString();
                technicianComboBox.SelectedItem = myIncident.TechnicianName;
            }
            else
            {
                incidentErrorLabel.Text = "No Incident found!";
                incidentErrorLabel.ForeColor = Color.Red;
                incidentErrorLabel.Visible = true;
            }
        }
    }
}
