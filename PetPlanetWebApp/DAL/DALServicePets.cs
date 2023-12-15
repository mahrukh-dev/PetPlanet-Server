using System.Data.SqlClient;
using System.Data;
using PetPlanetWebApp.Models;
using System.Collections.Generic;

namespace PetPlanetWebApp.DAL
{
    public class DALServicePets
    {
        public static void InsertPet(Pet pet)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_InsertPet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", pet.Name);
                    cmd.Parameters.AddWithValue("@Type", pet.Type);
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
                }
            }
        }

        public static void DeletePet(int petId)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_DeletePet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PetId", petId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePet(Pet pet)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_UpdatePet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PetId", pet.Id);
                    cmd.Parameters.AddWithValue("@Name", pet.Name);
                    cmd.Parameters.AddWithValue("@Type", pet.Type);
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
                }
            }
        }

        public static List<Pet> GetPets()
        {
            List<Pet> pets = new List<Pet>();

            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SP_GetAllPets", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pet pet = new Pet
                            {
                                Id = (int)reader["Id"],
                                Name = reader["Name"].ToString(),
                                Type = reader["Type"].ToString(),
                                Species = reader["Species"].ToString(),
                                Breed = reader["Breed"].ToString(),
                                Color = reader["Color"].ToString(),
                                Age = (int)reader["Age"],
                                Gender = reader["Gender"].ToString(),
                                Size = reader["Size"].ToString(),
                                Coat = reader["Coat"].ToString(),
                                Description = reader["Description"].ToString(),
                                ContactEmail = reader["ContactEmail"].ToString(),
                                ContactPhone = reader["ContactPhone"].ToString(),
                                ContactAddress = reader["ContactAddress"].ToString(),
                                Photo = reader["Photo"] as byte[]
                            };
                            pets.Add(pet);
                        }
                    }
                }
            }

            return pets;
        }
    }
}
