namespace TechSupport.UserControls
{
    partial class OpenIncidentsUserControl
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
            openedIncidentsListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // openedIncidentsListView
            // 
            openedIncidentsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            openedIncidentsListView.Dock = DockStyle.Fill;
            openedIncidentsListView.Location = new Point(0, 0);
            openedIncidentsListView.Name = "openedIncidentsListView";
            openedIncidentsListView.Size = new Size(591, 292);
            openedIncidentsListView.TabIndex = 0;
            openedIncidentsListView.TileSize = new Size(1, 1);
            openedIncidentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product Code";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date Opened";
            // 
            // OpenIncidents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(openedIncidentsListView);
            Name = "OpenIncidents";
            Size = new Size(591, 292);
            ResumeLayout(false);
        }

        #endregion

        private ListView openedIncidentsListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
