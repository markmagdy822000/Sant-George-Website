using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sant_George_Website.Models
{
    [PrimaryKey(nameof(StudentId),nameof(QuestionId))]
    public class Student_Answer_Text
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
