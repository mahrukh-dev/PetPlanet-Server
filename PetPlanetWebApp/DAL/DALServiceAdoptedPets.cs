using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetPlanetWebApp.Models;
using PetPlanetWebApp.Pages;

namespace PetPlanetWebApp.DAL
{
    public class DALServiceAdoptedPets
    {
        public static void InsertAdoptedPet(AdoptedPet adoptedPet)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertAdoptedPet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", adoptedPet.Id);
                    cmd.Parameters.AddWithValue("@Name", adoptedPet.Name);
                    cmd.Parameters.AddWithValue("@Type", adoptedPet.Type);
                    cmd.Parameters.AddWithValue("@Species", adoptedPet.Species);
                    cmd.Parameters.AddWithValue("@Breed", adoptedPet.Breed);
                    cmd.Parameters.AddWithValue("@Color", adoptedPet.Color);
                    cmd.Parameters.AddWithValue("@Age", adoptedPet.Age);
                    cmd.Parameters.AddWithValue("@Gender", adoptedPet.Gender);
                    cmd.Parameters.AddWithValue("@Size", adoptedPet.Size);
                    cmd.Parameters.AddWithValue("@Coat", adoptedPet.Coat);
                    cmd.Parameters.AddWithValue("@Description", adoptedPet.Description);
                    cmd.Parameters.AddWithValue("@ContactEmail", adoptedPet.ContactEmail);
                    cmd.Parameters.AddWithValue("@ContactPhone", adoptedPet.ContactPhone);
                    cmd.Parameters.AddWithValue("@ContactAddress", adoptedPet.ContactAddress);
                    cmd.Parameters.AddWithValue("@Photo", adoptedPet.Photo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAdoptedPet(int petId)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteAdoptedPet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PetId", petId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAdoptedPet(AdoptedPet adoptedPet)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateAdoptedPet", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PetId", adoptedPet.Id);
                    cmd.Parameters.AddWithValue("@Name", adoptedPet.Name);
                    cmd.Parameters.AddWithValue("@Type", adoptedPet.Type);
                    cmd.Parameters.AddWithValue("@Species", adoptedPet.Species);
                    cmd.Parameters.AddWithValue("@Breed", adoptedPet.Breed);
                    cmd.Parameters.AddWithValue("@Color", adoptedPet.Color);
                    cmd.Parameters.AddWithValue("@Age", adoptedPet.Age);
                    cmd.Parameters.AddWithValue("@Gender", adoptedPet.Gender);
                    cmd.Parameters.AddWithValue("@Size", adoptedPet.Size);
                    cmd.Parameters.AddWithValue("@Coat", adoptedPet.Coat);
                    cmd.Parameters.AddWithValue("@Description", adoptedPet.Description);
                    cmd.Parameters.AddWithValue("@ContactEmail", adoptedPet.ContactEmail);
                    cmd.Parameters.AddWithValue("@ContactPhone", adoptedPet.ContactPhone);
                    cmd.Parameters.AddWithValue("@ContactAddress", adoptedPet.ContactAddress);
                    cmd.Parameters.AddWithValue("@Photo", adoptedPet.Photo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<AdoptedPet> GetAdoptedPets()
        {
            List<AdoptedPet> adoptedPets = new List<AdoptedPet>();

            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllAdoptedPets", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdoptedPet adoptedPet = new AdoptedPet
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
                            adoptedPets.Add(adoptedPet);
                        }
                    }
                }
            }

            return adoptedPets;
        }
    }
}
