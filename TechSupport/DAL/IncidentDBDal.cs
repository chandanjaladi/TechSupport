using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    internal class IncidentDBDal
    {
        public List<OpenIncidents> GetIncidents() 
        {
            var openIncidents = new List<OpenIncidents>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Incidents.ProductCode,Incidents.DateOpened,Customers.Name,Technicians.Name,Incidents.Title from Incidents,Technicians,Customers where Incidents.CustomerID = Customers.CustomerID and Incidents.TechID = Technicians.TechID";
            using var command = new SqlCommand(query,connection);
            using var reader = command.ExecuteReader();
            var productCodeOrdinal = reader.GetOrdinal("Incidents.ProductCode");
            var dateOpenedOrdinal = reader.GetOrdinal("Incidents.DateOpened");
            var customersNameOrdinal = reader.GetOrdinal("Customers.Name");
            var techniciansNameOrdinal = reader.GetOrdinal("Technicians.Name");
            var titleOrdinal = reader.GetOrdinal("Incidents.Title");
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
