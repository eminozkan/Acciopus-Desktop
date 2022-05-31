using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.User
{
    class Request
    {
        public static RequestStatements sendRequest(User user,int IlanID,String Aciklama)
        {
            RequestStatements result = RequestStatements.Fail;
            SqlConnection sqlConnection = new SqlConnection(Config.Configuration.getConnectionString());
            try
            {
               
                SqlCommand sendRequestInfo = new SqlCommand("insert into Basvuru(basvuru_yapan_id,basvurulan_ilan_id,basvuru_aciklama,basvuru_tarihi,basvuru_durum) values(@p1,@p2,@p3,@p4,@p5)", sqlConnection);
                sendRequestInfo.Parameters.AddWithValue("@p1", user.getID());
                sendRequestInfo.Parameters.AddWithValue("@p2", IlanID);
                sendRequestInfo.Parameters.AddWithValue("@p3", Aciklama);
                sendRequestInfo.Parameters.AddWithValue("@p4", DateTime.Now);
                sendRequestInfo.Parameters.AddWithValue("@p5", "Bekleniyor");

                sqlConnection.Open();
                sendRequestInfo.ExecuteNonQuery();
                sqlConnection.Close();

                result = RequestStatements.Success;
            }catch(Exception e)
            {
                
                SqlCommand sendExceptiontoDatabase = new SqlCommand("Insert into Exception (Exception_Message,Exception_DateTime) values(@p1,@p2)", sqlConnection);

                sendExceptiontoDatabase.Parameters.AddWithValue("@p1", e.Message.ToString());
                sendExceptiontoDatabase.Parameters.AddWithValue("@p2", DateTime.Now);
                sendExceptiontoDatabase.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return result;
        }
    }
}
