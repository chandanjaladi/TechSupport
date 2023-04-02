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
                    TechnicianName = technicians,
                    Title = title
                });
            }
            return openIncidents;
        }

        /// <summary>
        /// Gets the customer names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetCustomerNames()
        {
            var customers = new List<String>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Name from customers";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var customerNameOrdinal = reader.GetOrdinal("Name");
            while(reader.Read())
            {
                var customer = reader.GetString(customerNameOrdinal);
                customers.Add(customer);
            }
            return customers;
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetProductNames()
        {
            var products = new List<String>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Name from products";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var productNameOrdinal = reader.GetOrdinal("Name");
            while (reader.Read())
            {
                var product = reader.GetString(productNameOrdinal);
                products.Add(product);
            }
            return products;
        }

        public List<string> GetTechinicansNames()
        {
            var technicians = new List<String>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Name from technicians";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var productNameOrdinal = reader.GetOrdinal("Name");
            while (reader.Read())
            {
                var product = reader.GetString(productNameOrdinal);
                technicians.Add(product);
            }
            return technicians;
        }

        /// <summary>
        /// Checks if the customers and products are registered or not.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public bool CheckRegisteredProductOrNot(int customerID, string productCode)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select count(*) from registrations" + 
                " where CustomerID = @customerID and ProductCode = @productCode";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@customerID", System.Data.SqlDbType.VarChar);
            command.Parameters["@customerID"].Value = customerID;
            command.Parameters.Add("@productCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@productCode"].Value = productCode;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public void AddIncident(Incident myIncident)
        {
            var customerID = myIncident.CustomerID;
            var productCode = myIncident.ProductCode;
            var title = myIncident.Title;
            var description = myIncident.Description;
            var dateOpened = DateTime.Now;
            using var connection = DBConnection.GetConnection();
            connection.Open();

            const string query = "INSERT INTO Incidents(CustomerID,ProductCode,DateOpened,Title,Description) " + 
                "values(@customerID,@productCode,@dateOpened,@title,@description)";

            using var command = new SqlCommand( query, connection);

            command.Parameters.Add("@customerID",System.Data.SqlDbType.Int);
            command.Parameters["@customerID"].Value = customerID;

            command.Parameters.Add("@productCode",System.Data.SqlDbType.VarChar);
            command.Parameters["@productCode"].Value = productCode;

            command.Parameters.Add("@dateOpened", System.Data.SqlDbType.Date);
            command.Parameters["@dateOpened"].Value = dateOpened;

            command.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
            command.Parameters["@title"].Value = title;

            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command.Parameters["@description"].Value = description;

            command.ExecuteNonQuery();
        }   

        public int GetCustomerID(string customerName)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select CustomerID from customers where Name = @customerName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@customerName", System.Data.SqlDbType.VarChar);
            command.Parameters["@customerName"].Value = customerName;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }

        public int GetTechID(string technicianName)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select TechID from technicians where Name = @technicianName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@technicianName", System.Data.SqlDbType.VarChar);
            command.Parameters["@technicianName"].Value = technicianName;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count;
        }

        public string GetProductCode(string productName)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select ProductCode from products where Name = @productName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;
            using var reader = command.ExecuteReader();
            var productCodeOrdinal = reader.GetOrdinal("ProductCode");
            var productCode = "";
            while (reader.Read())
            {
                productCode = reader.GetString(productCodeOrdinal);
            }
            return productCode;
        }

        public UpdateIncident GetParticularIncident(int incidentID)
        {
            var incident = new UpdateIncident();
            if (!CheckIncidentPresentOrNot(incidentID))
            {
                using var connection = DBConnection.GetConnection();
                connection.Open();
                const string query = "select Customers.Name as CustomerName, ProductCode, Technicians.Name as TechnicianName , DateOpened, Title, Description " +
                                        "from Customers, incidents " +
                                        "left join Technicians " +
                                        "on Technicians.TechID = Incidents.TechID " +
                                        "where IncidentID = @incidentID and Incidents.CustomerID = Customers.CustomerID";
                using var command = new SqlCommand(query, connection);
                command.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
                command.Parameters["@incidentID"].Value = incidentID;
                using var reader = command.ExecuteReader();
                var customersNameOrdinal = reader.GetOrdinal("CustomerName");
                var productCodeOrdinal = reader.GetOrdinal("ProductCode");
                var technicianOrdinal = reader.GetOrdinal("TechnicianName");
                var dateOpenedOrdinal = reader.GetOrdinal("DateOpened");
                var titleOrdinal = reader.GetOrdinal("Title");
                var descriptionOrdinal = reader.GetOrdinal("Description");
                while (reader.Read())
                {
                    var productCode = reader.GetString(productCodeOrdinal);
                    var dateOpened = reader.GetDateTime(dateOpenedOrdinal);
                    var customerName = reader.GetString(customersNameOrdinal);
                    var technicianName = "";
                    var title = reader.GetString(titleOrdinal);
                    var description = reader.GetString(descriptionOrdinal);

                    if (reader.IsDBNull(technicianOrdinal))
                    {
                        technicianName = "-- Unassigned --";
                    }
                    else
                    {
                        technicianName = reader.GetString(technicianOrdinal);
                    }

                    incident = new UpdateIncident
                    {
                        ProductCode = productCode,
                        OpenedDate = dateOpened,
                        CustomerName = customerName,
                        TechnicianName = technicianName,
                        Title = title,
                        Description = description,
                        IncidentID = incidentID
                    };
                }
                return incident;
            }
            else
            {
                return (incident = null);
            }
            
        }

        public bool CheckIncidentPresentOrNot (int incidentID)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select count(*) from incidents" +
                " where IncidentID = @incidentID";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@incidentID", System.Data.SqlDbType.Int);
            command.Parameters["@incidentID"].Value = incidentID;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 0;
        }

        public void UpdateIncident(UpdateIncident myIncident)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "update incidents " + 
                "set TechID = @techID, Description = @description";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@techID", System.Data.SqlDbType.Int);
            command.Parameters["@techID"].Value = GetTechID(myIncident.TechnicianName);
            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command.Parameters["@description"].Value = myIncident.Description;

            command.ExecuteNonQuery();

        }

        public void UpdateIncidentDescription(UpdateIncident myIncident)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "update incidents " +
                "set Description = @description";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command.Parameters["@description"].Value = myIncident.Description;
            command.ExecuteNonQuery();
        }

        public void UpdateIncidentTechnician(UpdateIncident myIncident)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "update incidents " +
                "set TechID = @techID";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@techID", System.Data.SqlDbType.Int);
            command.Parameters["@techID"].Value = GetTechID(myIncident.TechnicianName);
            command.ExecuteNonQuery();
        }
    }
}
