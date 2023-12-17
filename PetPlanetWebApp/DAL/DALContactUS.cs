using System.Data.SqlClient;
using System.Data;
using PetPlanetWebApp.Models;

namespace PetPlanetWebApp.DAL
{
	public class DALContactUS
	{
		public static void InsertContactUs(string email)
		{
			SqlConnection con = DBHelpPetService.GetConnection();
			con.Open();
			SqlCommand cmd = new SqlCommand("InsertContactUs", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@Email", email);
			cmd.ExecuteNonQuery();
			con.Close();
		}
	}
}
