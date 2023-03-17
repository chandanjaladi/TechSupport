namespace TechSupport.UserControls
{
    partial class DisplayIncident
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.incidentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.RowHeadersWidth = 51;
            this.incidentsDataGridView.RowTemplate.Height = 25;
            this.incidentsDataGridView.Size = new System.Drawing.Size(1193, 508);
            this.incidentsDataGridView.TabIndex = 5;
            // 
            // DisplayIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentsDataGridView);
            this.Name = "DisplayIncident";
            this.Size = new System.Drawing.Size(1193, 508);
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView incidentsDataGridView;
    }
}
