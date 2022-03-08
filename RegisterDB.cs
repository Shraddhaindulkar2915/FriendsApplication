using System.Data;
using System.Data.SqlClient;
namespace FriendApp.Models
{
    public class RegisterDB
    {
        SqlConnection con = new SqlConnection("Data Source=SHRADDHAPC/SHRADDHASQL;Initial Catalog=Friends;Integrated Security=True");
        public void Register(UserRegistration ur)
        {
            con.Open();
            string sqlq = "Insert into User(Name,Phone,Password) values(@name,@phone,@pwd)";
            SqlCommand cmd = new SqlCommand(sqlq, con);
            cmd.Parameters.AddWithValue("@name", ur.Name);
            cmd.Parameters.AddWithValue("@phone", ur.Phone);
            cmd.Parameters.AddWithValue("@pwd", ur.ConfirmPassword);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
