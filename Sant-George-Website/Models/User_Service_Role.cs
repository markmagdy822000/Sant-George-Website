using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Sant_George_Website.Models
{
    
    public class User_Service_Role
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public ApplicationUser User{ get; set; }
        public Service Service{ get; set; }
        [ForeignKey(nameof(Service))]
        public int ServiceId { get; set; }
        public RoleType Role{ get; set; }

    }
    public enum RoleType
    {
        Student=0, Teacher=1, Admin=2, Super_Admin=4, Parent=8
    }
}
