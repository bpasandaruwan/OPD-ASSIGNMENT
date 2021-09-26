using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OPD_ASSIGNMENT.General
{
    public class App_Connection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ums"].ConnectionString;
        }
    }
}
