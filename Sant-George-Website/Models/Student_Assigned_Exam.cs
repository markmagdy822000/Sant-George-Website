using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sant_George_Website.Models
{
    [PrimaryKey(nameof(StudentId), nameof(ExamId))]
    public class Student_Assigned_Exam
    {
        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }
        [ForeignKey(nameof(Exam))]
        public int ExamId { get; set; }
        public Exam Exam{ get; set; }
    }
}
