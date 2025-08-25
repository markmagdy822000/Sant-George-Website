using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SantGeorgeWebsite.Models
{
    [PrimaryKey(nameof(StudentId), nameof(AnswerId))]
    public class StudentAnswerChoose
    {
        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public ApplicationUser Student{ get; set; }
        [ForeignKey(nameof(Answer))]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
