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

namespace TechSupport.View
{
    public partial class AddIncidentForm : Form
    {
        private IncidentController controller;
        public AddIncidentForm()
        {
            InitializeComponent();
            controller = new IncidentController();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
        }

        private void customerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            customerErrorLabel.Visible = false;
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var incident = new Incident
                {
                    Title = titleTextBox.Text,
                    Description = descriptionTextBox.Text,
                    CustomerID = Convert.ToInt32(customerIDTextBox.Text)
                };
                controller.Add(incident);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentNullException ex)
            {
                titleErrorLabel.Text = ex.Message;
                titleErrorLabel.ForeColor = Color.Red;
                titleErrorLabel.Visible = true;
            }
            catch (ArgumentException ex)
            {
                customerErrorLabel.Text = ex.Message;
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (FormatException ex)
            {
                customerErrorLabel.Text = "Customer number cannot be a string or empty";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (Exception ex) 
            {
                descriptionErrorLabel.Text = ex.Message;
                descriptionErrorLabel.ForeColor = Color.Red;
                descriptionErrorLabel.Visible = true;
            }
        }
    }
}
