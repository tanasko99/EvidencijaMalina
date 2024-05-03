using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class UserRepository
    {

        //funkcija za prikupljanje korisnika iz baze
        public List<User> GetAllUsers()
        {
            List<User> result = new List<User>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Korisnici";
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    User s = new User();
                    s.JMBG = sqlDataReader.GetDecimal(0);
                    s.Ime = sqlDataReader.GetString(1);
                    s.Prezime = sqlDataReader.GetString(2);
                    s.Adresa = sqlDataReader.GetString(3);
                    s.Uloga = sqlDataReader.GetString(4);
                    s.Telefon = sqlDataReader.GetString(5);

                    result.Add(s);
                }

            }
            return result;
        }

        
    }
}