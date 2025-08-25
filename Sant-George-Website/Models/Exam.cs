using System.ComponentModel.DataAnnotations.Schema;

namespace SantGeorgeWebsite.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StarteDate { get; set; }
        public int Duration { get; set; }
        public int MaxDegree{ get; set; }
        public int MinDegree { get; set; }
        public string? Description { get; set; }
        [ForeignKey(nameof(Teacher))]
        public string TeacherId{ get; set; }
        public ApplicationUser Teacher { get; set; }
        public ICollection<Question> Questions{ get; set; }

    }
}
