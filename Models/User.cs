namespace WebAppiUsers.Models
{
    public class User : Entity
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int Sso { get; set; }
    }
}
