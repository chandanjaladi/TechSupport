namespace TechSupport.View
{
    partial class AddIncidentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.titleErrorLabel = new System.Windows.Forms.Label();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Incident Detials";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CustomerID:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(183, 92);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(157, 27);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(183, 157);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(157, 89);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(183, 291);
            this.customerIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(157, 27);
            this.customerIDTextBox.TabIndex = 6;
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Location = new System.Drawing.Point(72, 384);
            this.addIncidentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(105, 37);
            this.addIncidentButton.TabIndex = 7;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // titleErrorLabel
            // 
            this.titleErrorLabel.AutoSize = true;
            this.titleErrorLabel.Location = new System.Drawing.Point(131, 127);
            this.titleErrorLabel.Name = "titleErrorLabel";
            this.titleErrorLabel.Size = new System.Drawing.Size(74, 20);
            this.titleErrorLabel.TabIndex = 8;
            this.titleErrorLabel.Text = "Title Error";
            this.titleErrorLabel.Visible = false;
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Location = new System.Drawing.Point(131, 252);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(121, 20);
            this.descriptionErrorLabel.TabIndex = 9;
            this.descriptionErrorLabel.Text = "Descritpion Error";
            this.descriptionErrorLabel.Visible = false;
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.Location = new System.Drawing.Point(131, 325);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(123, 20);
            this.customerErrorLabel.TabIndex = 10;
            this.customerErrorLabel.Text = "CustomerID Error";
            this.customerErrorLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(192, 384);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 37);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(389, 448);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.customerErrorLabel);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.titleErrorLabel);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private TextBox customerIDTextBox;
        private Button addIncidentButton;
        private Label titleErrorLabel;
        private Label descriptionErrorLabel;
        private Label customerErrorLabel;
        private Button cancelButton;
    }
}