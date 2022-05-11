using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Session
{
    class Session
    {
        private static int ActiveSessionID = -1;
        public static void StartSession(SqlConnection sqlConnection,User.User user)
        {
            SqlCommand startSession = new SqlCommand("Insert into Session (session_user_id,session_start_time) values (@p1,@p2)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader;

            startSession.Parameters.AddWithValue("@p1", user.getID());
            startSession.Parameters.AddWithValue("@p2", DateTime.Now);
            startSession.ExecuteNonQuery();
            sqlConnection.Close();

            SqlCommand getSessionID = new SqlCommand("Select session_id from Session where session_user_id = @p1", sqlConnection);


            getSessionID.Parameters.AddWithValue("@p1", user.getID());
            sqlConnection.Open();
            reader = getSessionID.ExecuteReader();

            while (reader.Read())
            {
                ActiveSessionID = Convert.ToInt32(reader["session_id"]);
            }
            sqlConnection.Close();




        }

        public static void StopSession(SqlConnection database)
        {
            SqlCommand stopSession = new SqlCommand("UPDATE Session SET session_end_time = @end_time where session_id = @p2", database);
            stopSession.Parameters.AddWithValue("@p2", ActiveSessionID);
            stopSession.Parameters.AddWithValue("@end_time", DateTime.Now);
            database.Open();
            stopSession.Connection = database;


            stopSession.ExecuteNonQuery();
            database.Close();
            ActiveSessionID = -1;
        }



    }
}
