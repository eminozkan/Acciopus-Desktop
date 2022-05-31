using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus.Post
{
    class ChangeRequestState
    {

        public static RequestStatements setRequestState(ChangeRequestStatements state,int request_id)
        {
            RequestStatements result = RequestStatements.Fail;
            SqlCommandStatements sqlState = SqlCommandStatements.Fail;
            if (state == ChangeRequestStatements.Approved) 
            {
                SqlCommand sqlCommand = new SqlCommand("update Basvuru set basvuru_durum = 'Onaylandı' where basvuru_id = @p1");
                sqlCommand.Parameters.AddWithValue("@p1", request_id);
                sqlState = App.sendSqlCommand(sqlCommand);
                

            }else if(state == ChangeRequestStatements.NonApproved)
            {
                SqlCommand sqlCommand = new SqlCommand("update Basvuru set basvuru_durum = 'Reddedildi' where basvuru_id = @p1");
                sqlCommand.Parameters.AddWithValue("@p1", request_id);
                sqlState = App.sendSqlCommand(sqlCommand);
            }

            if(sqlState == SqlCommandStatements.Success)
            {
                result = RequestStatements.Success;
            }

            return result;
        }

    }
}
