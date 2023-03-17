using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    internal class IncidentDBDal
    {
        public List<OpenIncidents> GetOpenIncidents() 
        {
            var openIncidents = new List<OpenIncidents>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Incidents.ProductCode,Incidents.DateOpened,Customers.Name as customerName,Technicians.Name,Incidents.Title from Incidents,Technicians,Customers where Incidents.CustomerID = Customers.CustomerID and Incidents.TechID = Technicians.TechID and Incidents.DateClosed is null";
            using var command = new SqlCommand(query,connection);
            using var reader = command.ExecuteReader();
            var productCodeOrdinal = reader.GetOrdinal("ProductCode");
            var dateOpenedOrdinal = reader.GetOrdinal("DateOpened");
            var customersNameOrdinal = reader.GetOrdinal("customerName");
            var techniciansNameOrdinal = reader.GetOrdinal("Name");
            var titleOrdinal = reader.GetOrdinal("Title");
            while (reader.Read())
            {
                var productCode = reader.GetString(productCodeOrdinal);
                var dateOpened = reader.GetDateTime(dateOpenedOrdinal);
                var customersName = reader.GetString(customersNameOrdinal);
                var technicians = reader.GetString(techniciansNameOrdinal);
                var title = reader.GetString(titleOrdinal);

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
