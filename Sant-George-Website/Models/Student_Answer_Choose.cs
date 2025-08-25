using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sant_George_Website.Models
{
    [PrimaryKey(nameof(StudentId), nameof(AnswerId))]
    public class Student_Answer_Choose
    {
        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; }
        public ApplicationUser Student{ get; set; }
        [ForeignKey(nameof(Answer))]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
