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
    /// <summary>
    /// This is user control class of updateIncident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class UpdateIncidentUserControl : System.Windows.Forms.UserControl
    {
        private IncidentController _controller;
        List<string> techniciansNames = new List<string>();
        UpdateIncident myIncident;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            _controller = new IncidentController();
            UpdateTechnicians();
            myIncident = new UpdateIncident();
        }

        private void UpdateTechnicians()
        {
            techniciansNames = _controller.GetTechniciansNames();
            techniciansNames.Add("-- Unassigned --");
            foreach (string technician in techniciansNames)
            {
                technicianComboBox.Items.Add(technician);
            }
            technicianComboBox.SelectedIndex = 0;
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
            textToAddTextBox.Enabled = false;
        }

        private void getIncident_Click(object sender, EventArgs e)
        {
            incidentErrorLabel.Visible = false;
            updateErrorLabel.Visible = false;

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
                    dateOpenedTextBox.Text = myIncident.OpenedDate.ToShortDateString();

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
                    textToAddTextBox.Enabled = true;
                    textToAddTextBox.Clear();
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
            if ((technicianComboBox.SelectedItem.ToString() == myIncident.TechnicianName && textToAddTextBox.Text == "") || myIncident.ClosedDate != new DateTime())
            {
                updateErrorLabel.Text = "Cannot update closed item OR with no new changes";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;
            }
            else
            {
                if (descriptionTextBox.Text.Length < 200)
                {
                    if (textToAddTextBox.Text != "" && technicianComboBox.SelectedItem.ToString() != myIncident.TechnicianName)
                    {

                        if (CheckDescription() == DialogResult.OK)
                        {
                            var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now.ToShortDateString() + ">" + textToAddTextBox.Text;
                            myIncident.Description = Truncate(description, 200);
                            myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                            UpdateIncident();
                        }
                    }
                    else if (textToAddTextBox.Text != "")
                    {
                        if (CheckDescription() == DialogResult.OK)
                        {
                            var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now.ToShortDateString() + ">" + textToAddTextBox.Text;
                            myIncident.Description = Truncate(description, 200);
                            UpdateIncident();
                        }
                    }
                    else
                    {
                        if (technicianComboBox.SelectedItem.ToString() != "-- Unassigned --")
                        {
                            myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                            UpdateIncident();
                        }
                        else
                        {
                            updateErrorLabel.Text = "Cannot update with unassigned technician";
                            updateErrorLabel.ForeColor = Color.Red;
                            updateErrorLabel.Visible = true;
                        }
                    }
                }
                else
                {
                    updateErrorLabel.Text = "Description limit is reached only technician can be updated";
                    updateErrorLabel.ForeColor = Color.Red;
                    updateErrorLabel.Visible = true;
                }
            }
        }

        private DialogResult CheckDescription()
        {
            DialogResult overloadedDescription = DialogResult.OK;
            var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now.ToShortDateString() + ">" + textToAddTextBox.Text;
            if (description.Length >= 200)
            {
                overloadedDescription = MessageBox.Show("Description will be truncated as it is longer than 200 characters", "Truncate Description", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            return overloadedDescription;
        }

        private void UpdateIncident()
        {
            _controller.UpdateIncident(myIncident);
            updateErrorLabel.Text = "Incident updated successfully";
            updateErrorLabel.ForeColor = Color.Green;
            updateErrorLabel.Visible = true;
            textToAddTextBox.Clear();
            descriptionTextBox.Text = myIncident.Description;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (technicianComboBox.SelectedItem.ToString() != "-- Unassigned --")
            {
                DialogResult result;
                if (textToAddTextBox.Text != "" && technicianComboBox.SelectedItem.ToString() != myIncident.TechnicianName)
                {
                    if (CheckDescription() == DialogResult.OK)
                    {
                        var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now.ToShortDateString() + ">" + textToAddTextBox.Text;
                        myIncident.Description = Truncate(description, 200);
                        myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                    }
                    result = MessageBox.Show("Would you like to close the incident? You cannot update the incident after closing it!", "Closing incident", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        CloseIncident();
                    }
                }
                else if (textToAddTextBox.Text != "")
                {
                    if (CheckDescription() == DialogResult.OK)
                    {
                        var description = descriptionTextBox.Text + "\r\n" + "<" + DateTime.Now.ToShortDateString() + ">" + textToAddTextBox.Text;
                        myIncident.Description = Truncate(description, 200);

                    }
                    result = MessageBox.Show("Would you like to close the incident? You cannot update the incident after closing it!", "Closing incident", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        CloseIncident();
                    }
                }
                else
                {
                    if (technicianComboBox.SelectedItem.ToString() != "-- Unassigned --")
                    {
                        myIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();

                        result = MessageBox.Show("Would you like to close the incident?", "Closing incident", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                            CloseIncident();
                        }
                    }
                    else
                    {
                        updateErrorLabel.Text = "Cannot close with unassigned technician";
                        updateErrorLabel.ForeColor = Color.Red;
                        updateErrorLabel.Visible = true;
                    }
                }
            }
            else
            {
                updateErrorLabel.Text = "Cannot close incident with unassigned technician";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;
            }
        }

        private void CloseIncident()
        {
            UpdateIncident();
            _controller.CloseIncident(myIncident);
            updateErrorLabel.Text = "Incident closed successfully";
        }

        private string Truncate(string variable, int Length)
        {
            return variable.Length <= Length ? variable : variable.Substring(0, Length);
        }
    }
}
