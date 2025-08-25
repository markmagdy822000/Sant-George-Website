using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Sant_George_Website.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }
        public Post Post { get; set; }
        public string Text { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
