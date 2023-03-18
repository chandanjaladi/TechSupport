namespace TechSupport.Model
{
    /// <summary>
    /// This is the open incidents structure
    /// </summary>
    public class OpenIncidents
    {
        public string ProductCode { get; set; }
        public DateTime DateOpened { get; set; }
        public string CustomerName { get; set; }
        public string TechinicianName { get; set; }
        public string Title { get; set; }
    }
}
