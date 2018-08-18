using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderBot
{
    public class DataBase
    {
        SqlConnection con = new SqlConnection();

        public void InsertQuotation (String cdCurrency, String dtQuotation, String price)
        {
            string queryComand = "INSERT INTO PRICE ( CDCURRENCY, DTQUOTATION, VLPRICE ) VALUES ( " + cdCurrency + " , " + dtQuotation + " , " + price + " );";
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(queryComand, connection);
                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw(ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            string GetConnectionString()
            {
                return "Data Source=(local); Initial Catalog=TraderBotDB; Integrated Security=SSPI;";
            }
        }
    }
}
