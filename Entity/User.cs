using Microsoft.AspNetCore.Identity;

namespace MovieApp.Entity
{
    public class User : IdentityUser
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string ImageUrl { get; set; }

    }
}