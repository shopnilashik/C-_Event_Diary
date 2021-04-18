using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Event_Diary
{
    class MyConnection
    {
        public SqlConnection con;
        public MyConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);
        
        }
    }
}
