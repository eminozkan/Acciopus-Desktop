using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acciopus.User
{

    internal class Login
    {
        public static LoginStatements SignIn(SqlCommand sqlCommand,String userpass)
        {

            try
            {

                SqlDataReader reader;
                userpass = Encryption.Encryption.EncryptPassword(userpass);

                String t_mail = "default";
                String t_pass = "default";
                reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                   

                     t_mail = reader["kullanici_mail"].ToString();
                     t_pass = reader["kullanici_parola"].ToString();

                    
        
                    if (t_pass == userpass)
                    {
                        return LoginStatements.Success;
                    }
                    else
                    {
                        return LoginStatements.WrongPassword;
                    }
                }
                else
                {
                    return LoginStatements.WrongEmail;
                }


                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return LoginStatements.Fail;
        }

    }
}
