﻿    namespace PetPlanetWebApp.Models
{
    public class Address
    {
        public object address1 { get; set; }
        public object address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
    }

    public class Animal
    {
        public int id { get; set; }
        public string organization_id { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string species { get; set; }
        public Breeds breeds { get; set; }
        public Colors colors { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string size { get; set; }
        public string coat { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<Photo> photos { get; set; }
        public List<Video> videos { get; set; }
        public string status { get; set; }
        public Attributes attributes { get; set; }
        public Environment environment { get; set; }
        public List<string> tags { get; set; }
        public Contact contact { get; set; }
        public DateTime published_at { get; set; }
        public double distance { get; set; }
        public Links _links { get; set; }
    }

    public class Attributes
    {
        public bool spayed_neutered { get; set; }
        public bool house_trained { get; set; }
        public bool declawed { get; set; }
        public bool special_needs { get; set; }
        public bool shots_current { get; set; }
    }

    public class Breeds
    {
        public string primary { get; set; }
        public object secondary { get; set; }
        public bool mixed { get; set; }
        public bool unknown { get; set; }
    }

    public class Colors
    {
        public string primary { get; set; }
        public object secondary { get; set; }
        public object tertiary { get; set; }
    }

    public class Contact
    {
        public string email { get; set; }
        public string phone { get; set; }
        public Address address { get; set; }
    }

    public class Environment
    {
        public bool children { get; set; }
        public bool dogs { get; set; }
        public bool cats { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Type type { get; set; }
        public Organization organization { get; set; }
    }

    public class Organization
    {
        public string href { get; set; }
    }

    public class Pagination
    {
        public int count_per_page { get; set; }
        public int total_count { get; set; }
        public int current_page { get; set; }
        public int total_pages { get; set; }
        public Links _links { get; set; }
    }

    public class Photo
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string full { get; set; }
    }

    public class Root
    {
        public List<Animal> animals { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Type
    {
        public string href { get; set; }
    }

    public class Video
    {
        public string embed { get; set; }
    }
}
