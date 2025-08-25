using Microsoft.AspNetCore.Identity;

namespace Sant_George_Website.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Address { get; set; }
        public Gender Gender{ get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}
