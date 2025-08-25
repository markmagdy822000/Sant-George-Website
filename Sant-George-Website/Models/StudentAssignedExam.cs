using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SantGeorgeWebsite.Models
{
    [PrimaryKey(nameof(StudentId), nameof(ExamId))]
    public class StudentAssignedExam
    {
        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
        [ForeignKey(nameof(Exam))]
        public int ExamId { get; set; }
        public Exam Exam{ get; set; }
    }
}
