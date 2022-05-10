using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus
{
    class Application
    {
        private static SqlConnection sqlConnection = new SqlConnection(Config.Configuration.getConnectionString());
        public static void TryToLogin(String username,String Password)
        {
            SqlCommand sqlCommand = new SqlCommand("Select [kullanici_id][kullanici_mail][kullanici_parola] from Kullanici where kullanici_mail = @p1");
        }


    }
}
