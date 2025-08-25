using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SantGeorgeWebsite.Models
{
    [PrimaryKey(nameof(TeacherId), nameof(ExamId))]
    public class TeacherMarkExam
    {
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; }
        public ApplicationUser Teacher { get; set; }

        [ForeignKey(nameof(Exam))]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

    }
}
