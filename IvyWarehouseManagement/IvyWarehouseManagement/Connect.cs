using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvyWarehouseManagement
{
    internal static class Connect
    {
        internal static SqlConnection ConnectSQL()
        {
            string server = "VYDANGIUUUU";
            string db = "final";
            string connetionString = "Data Source="+server+";Initial Catalog="+db+ ";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connetionString);
            return connection;
        }
        
    }
}
