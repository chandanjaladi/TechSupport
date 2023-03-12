﻿using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// This class is used to add incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddIncidentForm : Form
    {
        private IncidentController controller;
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public AddIncidentForm()
        {
            InitializeComponent();
            controller = new IncidentController();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            customerErrorLabel.Visible = false;
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
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
            catch (FormatException)
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
