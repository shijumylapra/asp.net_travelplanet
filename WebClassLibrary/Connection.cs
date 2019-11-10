//Design and Coding Shiju Abraham 10-16-2019 @ Sait Project Term II
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebClassLibrary
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            // string connstring = @"Data Source = SHIJU\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            string connstring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            // string connstring = @"Data Source = SHIJU\SQLEXPRESS; Initial Catalog = TravelExperts; Integrated Security = True;  MultipleActiveResultSets = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            //string connstring = @"Data Source = SOFTDEV\SQLEXPRESS01; Initial Catalog = TravelExperts; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            SqlConnection con = new SqlConnection(connstring);
            return con;

        }

    }
}
