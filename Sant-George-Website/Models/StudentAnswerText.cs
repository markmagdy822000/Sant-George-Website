using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SantGeorgeWebsite.Models
{
    [PrimaryKey(nameof(StudentId),nameof(QuestionId))]
    public class StudentAnswerText
    {

        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string? Text{ get; set; }
    }
}
