using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
