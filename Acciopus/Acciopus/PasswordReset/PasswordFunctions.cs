using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.PasswordReset
{
    class PasswordFunctions
    {
        public static OldPasswordStatements CheckPassword(int UserID,String OldPass)
        {
            OldPasswordStatements result = OldPasswordStatements.NotSame;

            OldPass = Encryption.Encryption.EncryptPassword(OldPass);

            SqlConnection conn = new SqlConnection(Config.Configuration.getConnectionString());

            SqlCommand checkOldPass = new SqlCommand("Select kullanici_mail from Kullanici where kullanici_id = @p1 and kullanici_parola=@p2", conn);
            checkOldPass.Parameters.AddWithValue("@p1", UserID);
            checkOldPass.Parameters.AddWithValue("@p2", OldPass);
            SqlDataReader reader;

            conn.Open();
            reader = checkOldPass.ExecuteReader();
            if (reader.Read())
            {
                result = OldPasswordStatements.Same;
            }
            conn.Close();


            return result;
        }


        public static PasswordChangeStatements ChangePassword(int UserID,String NewPass)
        {
            PasswordChangeStatements result = PasswordChangeStatements.Fail;
            try
            {


                NewPass = Encryption.Encryption.EncryptPassword(NewPass);

                SqlConnection conn = new SqlConnection(Config.Configuration.getConnectionString());

                SqlCommand changePass = new SqlCommand("Update Kullanici set kullanici_parola = @p1 where kullanici_id = @p2", conn);

                changePass.Parameters.AddWithValue("@p1", NewPass);
                changePass.Parameters.AddWithValue("@p2", UserID);

                conn.Open();
                changePass.ExecuteNonQuery();
                conn.Close();

                result = PasswordChangeStatements.Success;

            }catch(Exception ex)
            {
                SqlConnection sql = new SqlConnection(Config.Configuration.getConnectionString());
                SqlCommand sendExceptiontoDatabase = new SqlCommand("Insert into Exception Exception_Message,Exception_DateTime values(@p1,@p2)", sql);
                
                sendExceptiontoDatabase.Parameters.AddWithValue("@p1", ex.Message.ToString());
                sendExceptiontoDatabase.Parameters.AddWithValue("@p2", DateTime.Now);
                sendExceptiontoDatabase.ExecuteNonQuery();
                sql.Close();
            }

            return result;

        }

    }
}
