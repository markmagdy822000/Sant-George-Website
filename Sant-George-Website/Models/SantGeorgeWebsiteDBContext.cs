using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SantGeorgeWebsite.Models
{
    public class SantGeorgeWebsiteDBContext : IdentityDbContext<ApplicationUser>
    {
        public SantGeorgeWebsiteDBContext(DbContextOptions<SantGeorgeWebsiteDBContext> options) : base(options) { }
            
        public DbSet<Answer>Answers{ get; set; }
        public DbSet<Exam >Exams { get; set; }
        public DbSet<Question >Questions { get; set; }
        public DbSet<StudentAnswerChoose >StudentAnswerChoose { get; set; }
        public DbSet<StudentAnswerText >StudentAnswerText { get; set; }
        public DbSet<StudentAssignedExam >StudentAssignedExam { get; set; }
        public DbSet<TeacherMarkExam >TeacherMarkExam { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
