using System.Data.SqlClient;

namespace PetPlanetWebApp.DAL
{
    public class DBHelpPetService
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9MFCUJA\\MAH;Initial Catalog=petplanet;Integrated Security=True");
            return con;
        }
    }
}
