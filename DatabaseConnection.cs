using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Thesim
{
    public class DatabaseConnection
    {
        private readonly string connectionString = "Server=DESKTOP-ONB5IAF;Database=Thesim;Integrated Security=True;";

        public DataTable GetSimData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Sim ORDER BY NgayKichHoat ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
