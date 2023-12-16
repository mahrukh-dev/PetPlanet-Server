namespace PetPlanetWebApp.Models
{
    public class AdoptionRequest
    {
        public string UserEmail { get; set; }
        public string UserAddress { get; set; }
        public string ContactNumber { get; set; }
        public string UserName { get; set; }
        public int AdoptionRequestId { get; set; }
        public int PetId { get; set; }
    }
}
