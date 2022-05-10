using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus
{
    class App
    {
        private static SqlConnection sqlConnection = new SqlConnection(Config.Configuration.getConnectionString());

        public static void TryToLogin(String email,String Password)
        {
            SqlCommand sqlCommand = new SqlCommand("Select [kullanici_id],[kullanici_mail],[kullanici_parola] from Kullanici where kullanici_mail = @p1",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", email);
            sqlConnection.Open();
            LoginStatements state = User.Login.SignIn(sqlCommand, Password);

            if(state == LoginStatements.Success)
            {
                MessageBox.Show("Giris Basarili!");

            }else if(state == LoginStatements.WrongEmail)
            {
                MessageBox.Show("Kullanici Bulunamadi!");
            }else if(state == LoginStatements.WrongPassword)
            {
                MessageBox.Show("Hatali Parola!");
            }

            sqlConnection.Close();

        
        }


        public static void SignUp(User.User us)
        {
            SqlCommand UserExist = new SqlCommand("Select [kullanici_mail] from Kullanici where kullanici_mail = @p1",sqlConnection);
            String email = us.getEmail();
            RegisterStatements state = RegisterStatements.Fail;
            UserExist.Parameters.AddWithValue("@p1", email);
            sqlConnection.Open();
            Boolean isUserExist = false;
            isUserExist = Registration.Registration.isUserExist(UserExist);
            sqlConnection.Close();
            
            if (isUserExist)
            {
                MessageBox.Show("Bu mail sistemde kayitlidir!");
            }
            else
            {
               state =  Registration.Registration.SignUp(us, sqlConnection);
            }

            if(state == RegisterStatements.Success)
            {
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show("Hata!!");
            }


        }


        
    }


}

