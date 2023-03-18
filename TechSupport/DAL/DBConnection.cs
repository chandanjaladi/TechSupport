using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class is used to connect tot DB
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection() 
        {
            const string connectionString = "Data source=(localdb)\\MSSQLLocalDB;Initial Catalog = TechSupport;Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
