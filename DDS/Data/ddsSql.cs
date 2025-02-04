using DDS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace DDS.Data
{
    public class ddsSql:Idds
    {
        private string ddsConnect;
        public ddsSql(IConfiguration configuration)
        {
            ddsConnect = configuration.GetConnectionString("ddsConnect");

        }
        
        public void Insert(ddsReg dds)

        {
              using(SqlConnection conn=new SqlConnection(ddsConnect))
                {
                conn.Open();
                string InsertQuery = "INSERT INTO ddsTable(RegName,RegMobile,RegEmail)VALUES(@RegName,@RegMobile,@RegEmail)";

                using (SqlCommand cmd = new SqlCommand(InsertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@RegName", dds.RegName);
                    cmd.Parameters.AddWithValue("@RegMobile", dds.RegMobile);
                    cmd.Parameters.AddWithValue("@RegEmail", dds.RegEmail);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }


        }

    }
}

