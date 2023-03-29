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

        /// <summary>
        /// Checks if the customers and products are registered or not.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public bool CheckRegisteredProductOrNot(string customerName, string productName)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select count(*) from registrations" + 
                " where CustomerID = (select CustomerID from customers where Name = @customerName) and ProductCode = (select ProductCode from products where Name = @productName)";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@customerName", System.Data.SqlDbType.VarChar);
            command.Parameters["@customerName"].Value = customerName;
            command.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;
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
        public void AddIncident(string customerName, string productName, string title, string description)
        {
            using var connection1 = DBConnection.GetConnection();
            using var connection2 = DBConnection.GetConnection();
            using var connection3 = DBConnection.GetConnection();
            connection1.Open();
            connection2.Open();
            connection3.Open();
            const string query1 = "select CustomerID from Customers where Name = @customerName";
            using var command1 = new SqlCommand(query1, connection1);
            command1.Parameters.Add("@customerName", System.Data.SqlDbType.VarChar);
            command1.Parameters["@customerName"].Value = customerName;
            const string query2 = "select ProductCode from Products where Name = @productName";
            using var command2 = new SqlCommand(query2, connection2);
            command2.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command2.Parameters["@productName"].Value = productName;
            int customerID = Convert.ToInt32(command1.ExecuteScalar());
            using var reader2 = command2.ExecuteReader();
            var productCodeOrdinal = reader2.GetOrdinal("ProductCode");
            var productCode = "";
            while (reader2.Read())
            {
                productCode = reader2.GetString(productCodeOrdinal);
            }
            var dateOpened = DateTime.Now;
            const string query3 = "INSERT INTO Incidents(CustomerID,ProductCode,DateOpened,Title,Description) " + 
                "values(@customerID,@productCode,@dateOpened,@title,@description)";
            using var command3 = new SqlCommand( query3, connection3);
            command3.Parameters.Add("@customerID",System.Data.SqlDbType.Int);
            command3.Parameters["@customerID"].Value = customerID;
            command3.Parameters.Add("@productCode",System.Data.SqlDbType.VarChar);
            command3.Parameters["@productCode"].Value = productCode;
            command3.Parameters.Add("@dateOpened", System.Data.SqlDbType.Date);
            command3.Parameters["@dateOpened"].Value = dateOpened;
            command3.Parameters.Add("@title", System.Data.SqlDbType.VarChar);
            command3.Parameters["@title"].Value = title;
            command3.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command3.Parameters["@description"].Value = description;
            command3.ExecuteNonQuery();
        }
    }
}
