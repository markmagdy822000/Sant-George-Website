using System.ComponentModel.DataAnnotations.Schema;

namespace SantGeorgeWebsite.Models
{
    public class UserParent
    {
        public ApplicationUser Parent{ get; set; }
        [ForeignKey(nameof(Parent))]
        public string ParentId { get; set; }

        [ForeignKey(nameof(Child))]
        public string ChildId{ get; set; }
        public ApplicationUser Child{ get; set; }
    }
}
