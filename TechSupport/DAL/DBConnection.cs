using System.Data.SqlClient;

namespace TechSupport.DAL
{
    public class DBConnection
    {
        public static SqlConnection GetConnection() 
        {
            const string connectionString = "Data source=(localdb)\\MSSQLLocalDB;Initial Catalog = TechSupport;Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
