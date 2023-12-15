using System.Data.SqlClient;
using System.Data;
using PetPlanetWebApp.Models;

namespace PetPlanetWebApp.DAL
{
    public class DALServiceUsers
    {
        public static void InsertUser(User user)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("CreateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_UserName", user.UserName);
            cmd.Parameters.AddWithValue("@p_UserEmail", user.UserEmail);
            cmd.Parameters.AddWithValue("@p_UserPassword", user.UserPassword);
            cmd.Parameters.AddWithValue("@p_Name", user.Name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static User ReadUser(int userId)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("ReadUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_UserID", userId);

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    UserID = (int)reader["UserID"],
                    UserName = reader["UserName"].ToString(),
                    UserEmail = reader["UserEmail"].ToString(),
                    UserPassword = reader["UserPassword"].ToString(),
                    Name = reader["Name"].ToString()
                };
            }

            reader.Close();
            con.Close();

            return user;
        }

        public static void UpdateUser(User user)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("UpdateUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_UserID", user.UserID);
            cmd.Parameters.AddWithValue("@p_UserName", user.UserName);
            cmd.Parameters.AddWithValue("@p_UserEmail", user.UserEmail);
            cmd.Parameters.AddWithValue("@p_UserPassword", user.UserPassword);
            cmd.Parameters.AddWithValue("@p_Name", user.Name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeleteUser(int userId)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_UserID", userId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable GetAllUsers()
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("GetAllUser", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtUsers = new DataTable();
            adapter.Fill(dtUsers);

            con.Close();

            return dtUsers;
        }

        public static User FindUserByEmail(string userEmail)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("FindUserByEmail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_UserEmail", userEmail);

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;

            if (reader.Read())
            {
                user = new User
                {
                    UserID = (int)reader["UserID"],
                    UserName = reader["UserName"].ToString(),
                    UserEmail = reader["UserEmail"].ToString(),
                    UserPassword = reader["UserPassword"].ToString(),
                    Name = reader["Name"].ToString()
                };
            }

            reader.Close();
            con.Close();

            return user;
        }

    }
}
