using System.Data.SqlClient;
using System.Data;
using PetPlanetWebApp.Models;

namespace PetPlanetWebApp.DAL
{
    public class DALServicePets
    {
        public static void InsertPet(Pet pet)
        {
            SqlConnection con = DBHelpPetService.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_InsertPet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", pet.Name);
            cmd.Parameters.AddWithValue("@Type", pet.Age);
            cmd.Parameters.AddWithValue("@Species", pet.Species);
            cmd.Parameters.AddWithValue("@Breed", pet.Breed);
            cmd.Parameters.AddWithValue("@Color", pet.Color);
            cmd.Parameters.AddWithValue("@Age", pet.Age);
            cmd.Parameters.AddWithValue("@Gender", pet.Gender);
            cmd.Parameters.AddWithValue("@Size", pet.Size);
            cmd.Parameters.AddWithValue("@Coat", pet.Coat);
            cmd.Parameters.AddWithValue("@Description", pet.Description);
            cmd.Parameters.AddWithValue("@ContactEmail", pet.ContactEmail);
            cmd.Parameters.AddWithValue("@ContactPhone", pet.ContactPhone);
            cmd.Parameters.AddWithValue("@ContactAddress", pet.ContactAddress);
            cmd.Parameters.AddWithValue("@Photo", pet.Photo);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void DeletePet()
        {

        }
        public static void UpdatePet()
        {

        }
        public static void GetPets()
        {

        }
    }
}
