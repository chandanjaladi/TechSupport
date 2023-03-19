using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// This is the class used for open incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class OpenIncidents : System.Windows.Forms.UserControl
    {
        private IncidentController _incidentController;
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIncidents"/> class.
        /// </summary>
        public OpenIncidents()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
        }
        /// <summary>
        /// Displays the open incidents.
        /// </summary>
        public void displayOpenIncidents() 
        {
            
                openedIncidentsListView.Clear();
                openedIncidentsListView.View = System.Windows.Forms.View.Details;
                openedIncidentsListView.Columns.Add("Product Code", 120);
                openedIncidentsListView.Columns.Add("Date Opened", 120);
                openedIncidentsListView.Columns.Add("Customer", 120);
                openedIncidentsListView.Columns.Add("Technicians", 120);
                openedIncidentsListView.Columns.Add("Title", 200);

                for (var i = 0; i < _incidentController.GetOpenIncidents().Count; i++)
                {
                    var lv = new ListViewItem(_incidentController.GetOpenIncidents()[i].ProductCode);
                    lv.SubItems.Add(_incidentController.GetOpenIncidents()[i].DateOpened.ToShortDateString());
                    lv.SubItems.Add(_incidentController.GetOpenIncidents()[i].CustomerName);
                    lv.SubItems.Add(_incidentController.GetOpenIncidents()[i].TechinicianName);
                    lv.SubItems.Add(_incidentController.GetOpenIncidents()[i].Title);
                    openedIncidentsListView.Items.Add(lv);
                }
            
            

        }
    }
}
