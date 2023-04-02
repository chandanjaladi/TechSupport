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
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : System.Windows.Forms.UserControl
    {
        private IncidentController _controller;
        List<string> techniciansNames = new List<string>();
        UpdateIncident myIncident;
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _controller = new IncidentController();
            techniciansNames = _controller.GetTechniciansNames();
            techniciansNames.Add("-- Unassigned --");
            foreach (string technician in techniciansNames)
            {
                technicianComboBox.Items.Add(technician);
            }
            technicianComboBox.SelectedIndex = 0;
            myIncident = new UpdateIncident();
            updateButton.Enabled = false;
            closeButton.Enabled = false;
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
            ClearAll();
        }

        private void ClearAll()
        {
            incidentTextBox.Clear();
            customerTextBox.Clear();
            productTextBox.Clear();
            titleTextBox.Clear();
            dateOpenedTextBox.Clear();
            descriptionTextBox.Clear();
            textToAddTextBox.Clear();
            technicianComboBox.SelectedIndex = techniciansNames.Count - 1;
            updateButton.Enabled = false;
            closeButton.Enabled = false;
        }

        private void getIncident_Click(object sender, EventArgs e)
        {
            incidentErrorLabel.Visible = false;

            try
            {
                int incidentID = Convert.ToInt32(incidentTextBox.Text);
                myIncident = _controller.GetParticularIncident(incidentID);
                if (myIncident != null)
                {
                    customerTextBox.Text = myIncident.CustomerName;
                    productTextBox.Text = myIncident.ProductCode;
                    titleTextBox.Text = myIncident.Title;
                    descriptionTextBox.Text = myIncident.Description;
                    dateOpenedTextBox.Text = myIncident.OpenedDate.ToString();

                    if (myIncident.TechnicianName != "-- Unassigned --")
                    {
                        technicianComboBox.SelectedItem = myIncident.TechnicianName;
                    }
                    else
                    {
                        technicianComboBox.SelectedIndex = techniciansNames.Count - 1;
                    }
                    updateButton.Enabled = true;
                    closeButton.Enabled = true;
                }
                else
                {
                    incidentErrorLabel.Text = "No Incident found!";
                    incidentErrorLabel.ForeColor = Color.Red;
                    incidentErrorLabel.Visible = true;
                }
            }
            catch (Exception)
            {
                incidentErrorLabel.Text = "No Incident found!";
                incidentErrorLabel.ForeColor = Color.Red;
                incidentErrorLabel.Visible = true;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (technicianComboBox.SelectedItem.ToString() == myIncident.TechnicianName && textToAddTextBox.Text == "")
            {
                updateErrorLabel.Text = "Cannot update with no new changes";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;
            }
            else
            {
                if (textToAddTextBox.Text != "" && technicianComboBox.SelectedItem.ToString() != myIncident.TechnicianName)
                {
                    var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now + ">" + textToAddTextBox.Text;
                    myIncident.Description = description;
                    myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                    _controller.UpdateIncident(myIncident);
                } 
                else if(textToAddTextBox.Text != "")
                {
                    var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now + ">" + textToAddTextBox.Text;
                    myIncident.Description = description;
                    _controller.UpdateIncidentDescription(myIncident);
                }
                else
                {
                    if (technicianComboBox.SelectedItem.ToString() != "-- Unassigned --")
                    {
                        myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                        _controller.UpdateIncidentTechnician(myIncident);
                    }
                    else
                    {
                        updateErrorLabel.Text = "Cannot update with unassigned technician";
                        updateErrorLabel.ForeColor = Color.Red;
                        updateErrorLabel.Visible = true;
                    }
                   
                }

            }
            ClearAll();
        }
    }
}
