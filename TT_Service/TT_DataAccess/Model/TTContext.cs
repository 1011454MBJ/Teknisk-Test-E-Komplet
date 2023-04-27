using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace TT_DataAccess.Model
{
    public class TTContext
    {
        private string _connectionString;

        public TTContext()
        {
            Initialize();
        }

        private string Initialize() 
        {
            // Opret forbindelse til SQL Server
            string _connectionString = "Server=.\\SQLExpress;Database=FitterTest;Integrated Security=true;";
            return _connectionString;
            //SqlConnection connection = new SqlConnection(connectionString);
            // Åbn forbindelse til databasen
            //connection.Open();

            //// Udfør SQL-kommando
            //string sql = "SELECT * FROM Fitters";
            //SqlCommand command = new SqlCommand(sql, connection);
            //SqlDataReader reader = command.ExecuteReader();

            //// Læs data fra databasen
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["FirstName"].ToString());
            //}

            //// Luk forbindelsen til databasen
            //reader.Close();
            //connection.Close();
            
        } 
    }
}
