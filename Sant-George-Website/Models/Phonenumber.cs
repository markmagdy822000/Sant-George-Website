using System.ComponentModel.DataAnnotations.Schema;

namespace Sant_George_Website.Models
{
    public class User_Phonenumber
    {
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User{ get; set; }
        public int Phonenumber { get; set; }
    }
}
