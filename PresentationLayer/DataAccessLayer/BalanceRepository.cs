using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class BalanceRepository
    {
        /*Funkcija za prikupljanje stanja iz tabele komora*/
        public List<Balance> GetBalance()
        {
            List<Balance> result = new List<Balance>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Komora";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Balance s = new Balance();
                    s.ID = sqlDataReader.GetInt32(0);
                    s.VrstaRobe = sqlDataReader.GetString(1);
                    s.JedinicaMere = sqlDataReader.GetString(2);
                    s.Kolicina = sqlDataReader.GetDecimal(3);
                    result.Add(s);
                }

            }
            return result;
        }
    }
}