using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT_DataAccess.Model;

namespace TT_DataAccess.Repository
{
    public class ForemanRepository
    {
        public ForemanRepository() 
        {
            Initialize();
        }
        private void Initialize()
        {
            // Opret forbindelse til SQL Server
            string connectionString = "Server=.\\SQLExpress;Database=FitterTest;";//IntegratedSecurity=true;";
            SqlConnection connection = new SqlConnection(connectionString);
            // Åbn forbindelse til databasen
            connection.Open();

            // Udfør SQL-kommando
            string sql = "SELECT TOP 1 FROM Fitters";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            //// Læs data fra databasen
            //while (reader.Read())
            //{
            //    return reader["FirstName"].ToString();
            //}

            // Luk forbindelsen til databasen
            reader.Close();
            connection.Close();
        }

        /* SQL Select all foremans, fitters basic info and their jobtitles statement
        "SELECT *
        FROM Foremans
        JOIN JobTitles ON Foremans.JobTitleID = JobTitles.JobTitleID
        LEFT JOIN FitterForeman ON FitterForeman.ForemanID= Foremans.ForemanID
        LEFT JOIN Fitters ON FitterForeman.FitterID= Fitters.FitterID
        LEFT JOIN JobTitles AS JobT ON Fitters.JobTitleID= JobT.JobTitleID
        WHERE Foremans.JobTitleID= 100"
        */
    }
}
