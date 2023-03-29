using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class is used to get the data from database
    /// </summary>
    public class IncidentDBDal
    {
        /// <summary>
        /// Gets the open incidents.
        /// </summary>
        /// <returns>List of all open incidents</returns>
        public List<OpenIncidents> GetOpenIncidents() 
        {

            var openIncidents = new List<OpenIncidents>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Incidents.ProductCode, Incidents.DateOpened, Customers.Name as customerName, Technicians.Name, Incidents.Title "
                + "from Customers, Incidents "
                + "left join Technicians " 
                + "on Technicians.TechID = Incidents.TechID "
                + "where Incidents.CustomerID = Customers.CustomerID and Incidents.DateClosed is null";
            using var command = new SqlCommand(query,connection);
            using var reader = command.ExecuteReader();
            var productCodeOrdinal = reader.GetOrdinal("ProductCode");
            var dateOpenedOrdinal = reader.GetOrdinal("DateOpened");
            var customersNameOrdinal = reader.GetOrdinal("customerName");
            var techniciansNameOrdinal = reader.GetOrdinal("Name");
            var titleOrdinal = reader.GetOrdinal("Title");
            while (reader.Read())
            {
                var productCode = "";
                var dateOpened = new DateTime();
                var customersName = "";
                var technicians = "";
                var title = "";
                productCode = reader.GetString(productCodeOrdinal);
                dateOpened = reader.GetDateTime(dateOpenedOrdinal);
                customersName = reader.GetString(customersNameOrdinal);
                title = reader.GetString(titleOrdinal);
                if (reader.IsDBNull(techniciansNameOrdinal))
                {
                    technicians = "Not Assigned";
                }
                else 
                {
                    technicians = reader.GetString(techniciansNameOrdinal);
                }

                openIncidents.Add(new OpenIncidents
                {
                    ProductCode = productCode,
                    DateOpened = dateOpened,
                    CustomerName = customersName,
                    TechinicianName = technicians,
                    Title = title
                });
            }
            return openIncidents;
        }
    }
}
