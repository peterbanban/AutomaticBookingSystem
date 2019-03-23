using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace AutomaticBookingSystem
{
    class Class2
    {
        public static  string sqlAnalyse(string sql,SqlConnection connection) {
           
            SqlCommand command = new SqlCommand(sql, connection);
            return  Convert.ToString(command.ExecuteScalar()) ;
        }
    }
}
