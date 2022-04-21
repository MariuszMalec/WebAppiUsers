using Microsoft.AspNetCore.Identity;

namespace WebAppiUsers.Models
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

    }
}
