using System.Data;
using System.Data.SqlClient;
using Elmah.ContentSyndication;
using Microsoft.AspNetCore.Http;
namespace FriendApp.Models
{
    public class Profiledb
    {
        SqlConnection con = new SqlConnection("Data Source=SHRADDHAPC/SHRADDHASQL;Initial Catalog=Friends;Integrated Security=True");
       =Profile pf = new Profile();
        public void getProfile()
        {   con.Open();
            string sqlq = "Select Name from Friends";
            SqlCommand cmd=new SqlCommand(sqlq,con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.HasRows)
                {
                    sdr.Read();     
                    pf.friendsListing.Add(sdr.GetString(item));
                }

        }
    }
}
