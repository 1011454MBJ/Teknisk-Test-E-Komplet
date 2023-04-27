using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT_DataAccess.Model;

namespace TT_DataAccess.Repository
{
    //
    public class ForemanRepository
    {
        //TODO Implement connection string in appsettings.json/config-file and use it here.
        //Basically just get it out of source code and eliminate security risks
        private string connectionString = "";
        
        public ForemanRepository() 
        {
            Initialize();
        }
        private void Initialize()
        { 
            connectionString = "Server=.\\SQLExpress;Database=FitterTest;Integrated Security=true;";
            //connectionString = new TTContext().ToString();
        }

         

        public IEnumerable<Foreman> GetAllForeman()
        {
            List<Foreman> foremans = new List<Foreman>();   
            
        // Opret forbindelse til SQL Server
            SqlConnection connection = new SqlConnection(connectionString);
            // Åbn forbindelse til databasen
            connection.Open();

            // Udfør SQL-kommando
            string sql =//"SELECT *\r\n" +
                        "SELECT TOP 1 *\r\n" +
                        "FROM Foremans\r\n" +
                        "JOIN JobTitles ON Foremans.JobTitleID = JobTitles.JobTitleID\r\n" +
                        "LEFT JOIN FitterForeman ON FitterForeman.ForemanID= Foremans.ForemanID\r\n" +
                        "LEFT JOIN Fitters ON FitterForeman.FitterID= Fitters.FitterID\r\n" +
                        "LEFT JOIN JobTitles AS JobT ON Fitters.JobTitleID= JobT.JobTitleID\r\n" +
                        "WHERE Foremans.JobTitleID= 100";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader fm = command.ExecuteReader();

            // TODO: Find out why data is not sent to out to Controller, but Breakpoints show it is read from DB.
            // Læs data fra databasen
            //while (foremen.Read())
            if (fm.Read())
            {
                string firstName = fm.GetString(fm.GetOrdinal("FirstName"));
                string lastName = fm.GetString(fm.GetOrdinal("LastName"));
                string phoneNumber = fm.GetString(fm.GetOrdinal("PhoneNumber"));
                string jobTitle = fm.GetString(fm.GetOrdinal("JobTitle"));
                //List<Fitter> FitterList = new List<Fitter>();
                Foreman f = new Foreman(firstName, lastName, phoneNumber, jobTitle);
                foremans.Add(f);
            }

            // Luk forbindelsen til databasen
            fm.Close();
            connection.Close();
            //return foremans;
            return foremans;
        }
    }
}
