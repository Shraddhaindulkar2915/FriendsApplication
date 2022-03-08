using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FriendApp.Models;
namespace FriendApp.Models
{ 
   
    public class Db
    {
        SqlConnection con = new SqlConnection("Data Source=SHRADDHAPC/SHRADDHASQL;Initial Catalog=Friends;Integrated Security=True");
        public int LoginCheck(LoginViewModel ad)
        {
            SqlCommand com = new SqlCommand("Sp_Login", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Phone", ad.userphone);
            com.Parameters.AddWithValue("@Password", ad.password);
            SqlParameter oblogin = new SqlParameter();
            oblogin.ParameterName = "@Isvalid";
            oblogin.SqlDbType = SqlDbType.Bit;
            oblogin.Direction = ParameterDirection.Output;
            com.Parameters.Add(oblogin);
            con.Open();
            com.ExecuteNonQuery();
            int res = Convert.ToInt32(oblogin.Value);
            con.Close();
            return res;


        }
    }
}
