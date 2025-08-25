using System.ComponentModel.DataAnnotations.Schema;

namespace Sant_George_Website.Models
{
    public class User_Parent
    {
        public ApplicationUser Parent{ get; set; }
        [ForeignKey(nameof(Parent))]
        public string ParentId { get; set; }

        [ForeignKey(nameof(Child))]
        public string ChildId{ get; set; }
        public ApplicationUser Child{ get; set; }
    }
}
