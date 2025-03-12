using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    class MainClass
    {
        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-52B5K6B; Initial catalog = School_Manage_System; Integrated Security = True;");
            conn.Open();
            return conn;
        }
    }
}
