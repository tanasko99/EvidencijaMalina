using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class TransactionRepository
    { //funkcija za prikupljanje transakcija iz baze
        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> result = new List<Transaction>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Transakcije";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Transaction s = new Transaction();
                    s.ID = sqlDataReader.GetInt32(0);
                    s.VrstaRobe = sqlDataReader.GetString(1);
                    s.Kolicina = sqlDataReader.GetDecimal(2);
                    s.OvlascenoLice = sqlDataReader.GetString(3);
                    s.KupacProizvodjac = sqlDataReader.GetString(4);
                    s.Datum = sqlDataReader.GetDateTime(5);
                    s.Vrsta = sqlDataReader.GetString(6);
                    result.Add(s);
                }

            }
            return result;
        }
        //funkcija za upisivanje transakcija u bazu
        public int InsertTransaction(Transaction s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Transakcije VALUES({0},'{1}',{2},'{3}','{4}','{5}','{6}')", s.ID, s.VrstaRobe, s.Kolicina, s.OvlascenoLice, s.KupacProizvodjac, s.Datum, s.Vrsta);

                return sqlCommand.ExecuteNonQuery();

            }
        }
    }
}