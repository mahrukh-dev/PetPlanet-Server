namespace PetPlanetWebApp.Models
{
    public class AdoptedPet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Coat { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactAddress { get; set; }
        public byte[] Photo { get; set; }

        // You can add more properties as needed, such as adoption date, status, etc.

        // Example constructor for initialization
        public AdoptedPet(string name, string type, string species, string breed, string color, int age, string gender, string size, string coat, string description, string contactEmail, string contactPhone, string contactAddress, byte[] photo)
        {
            Name = name;
            Type = type;
            Species = species;
            Breed = breed;
            Color = color;
            Age = age;
            Gender = gender;
            Size = size;
            Coat = coat;
            Description = description;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            ContactAddress = contactAddress;
            Photo = photo;
        }

        // Default constructor for model binding in forms
        public AdoptedPet()
        {
            // Default constructor is required for model binding in forms
        }
    }
}
