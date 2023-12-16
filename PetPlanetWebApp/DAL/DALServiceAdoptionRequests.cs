using System.Data;
using System.Data.SqlClient;
using PetPlanetWebApp.Models;
using System.Collections.Generic;

namespace PetPlanetWebApp.DAL
{
    public class DALServiceAdoptionRequests
    {
        public static void InsertAdoptionRequest(AdoptionRequest adoptionRequest)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("InsertAdoptionRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserEmail", adoptionRequest.UserEmail);
                    cmd.Parameters.AddWithValue("@UserAddress", adoptionRequest.UserAddress);
                    cmd.Parameters.AddWithValue("@ContactNumber", adoptionRequest.ContactNumber);
                    cmd.Parameters.AddWithValue("@UserName", adoptionRequest.UserName);
                    cmd.Parameters.AddWithValue("@PetId", adoptionRequest.PetId);
                    // Include other parameters for insert if needed
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAdoptionRequest(int adoptionRequestId)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteAdoptionRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdoptionRequestId", adoptionRequestId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAdoptionRequest(AdoptionRequest adoptionRequest)
        {
            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateAdoptionRequest", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdoptionRequestId", adoptionRequest.AdoptionRequestId);
                    cmd.Parameters.AddWithValue("@UserEmail", adoptionRequest.UserEmail);
                    cmd.Parameters.AddWithValue("@UserAddress", adoptionRequest.UserAddress);
                    cmd.Parameters.AddWithValue("@ContactNumber", adoptionRequest.ContactNumber);
                    cmd.Parameters.AddWithValue("@UserName", adoptionRequest.UserName);
                    cmd.Parameters.AddWithValue("@PetId", adoptionRequest.PetId);
                    // Include other parameters for update if needed
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<AdoptionRequest> GetAdoptionRequests()
        {
            List<AdoptionRequest> adoptionRequests = new List<AdoptionRequest>();

            using (SqlConnection con = DBHelpPetService.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllAdoptionRequests", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdoptionRequest adoptionRequest = new AdoptionRequest
                            {
                                AdoptionRequestId = (int)reader["AdoptionRequestId"],
                                UserEmail = reader["UserEmail"].ToString(),
                                UserAddress = reader["UserAddress"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                PetId = (int)reader["PetId"]
                                // Include other properties if needed
                            };
                            adoptionRequests.Add(adoptionRequest);
                        }
                    }
                }
            }

            return adoptionRequests;
        }
    }
}
