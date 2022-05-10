using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Registration
{
    internal class Registration
    {
        public static Boolean isUserExist(SqlCommand sqlCommand)
        {
            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void SignUp(User.User us,SqlConnection sql)
        {

            String sqlComm = "Insert into Kullanici(kullanici_adi,kullanici_soyadi,kullanici_parola,kullanici_mail,kullanici_telefon,kullanici_dogum_tarihi,kullanici_tip_id,kullanici_kayit_tarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            SqlCommand sendUserInfo = new SqlCommand(sqlComm, sql);
            sendUserInfo.Connection = sql;
            sendUserInfo.Parameters.AddWithValue("@p1", us.getName());
            sendUserInfo.Parameters.AddWithValue("@p2", us.getSurname());
            sendUserInfo.Parameters.AddWithValue("@p3", Encryption.Encryption.EncryptPassword(us.getPassword()));
            sendUserInfo.Parameters.AddWithValue("@p4", us.getEmail());
            sendUserInfo.Parameters.AddWithValue("@p5", us.getPhoneNumber());
            sendUserInfo.Parameters.AddWithValue("@p6", us.getDateofBirth());
            User.UserType type = us.getType();
            if (type == User.UserType.Employer)
            {
                sendUserInfo.Parameters.AddWithValue("@p7", 2);
            }else if(type == User.UserType.Worker)
            {
                sendUserInfo.Parameters.AddWithValue("@p7", 3);

            }
            sendUserInfo.Parameters.AddWithValue("@p8", DateTime.Now);

            sql.Open();
            sendUserInfo.ExecuteNonQuery();
            sql.Close();
        }
    }
}
