using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class Databaseconnection
    {
        public static SqlConnection Dataconnect { get; set; }
        public static void ConnectionDB(string ip, string dbname)
        {
            string connectionString = "Server=" + ip + ";Database=" + dbname + ";Trusted_Connection=True;";
            Dataconnect = new SqlConnection(connectionString);
            Dataconnect.Open();
        }
    }
}
