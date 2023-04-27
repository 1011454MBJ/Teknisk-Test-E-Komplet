using System.Data.SqlClient;
using TT_DataAccess.Model;
//using TT_DataAccess.Model.TTContext;

namespace TT_DataAccess
{
    public class TestafDBcontext
    {
        static void Main(string[] args)
        {
            //string connectionString = "Server=.\\SQLExpress;Database=FitterTest;Integrated Security=True;";
            //SqlConnection connection = new SqlConnection(connectionString);

            try
            {
               // TTContext context = new TTContext();
                //connection.Open();

                //SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM MyTable", connection);
                //SqlDataReader reader = command.ExecuteReader();

                //while (reader.Read())
                //{
                //    Console.WriteLine(reader[0] + "\t" + reader[1] + "\t" + reader[2]);
                //}
                //reader.Close();
            }
            catch (Exception ex)
            {
               // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                //connection.Close();
                //Console.WriteLine("All done");
            }

        }
    }
}