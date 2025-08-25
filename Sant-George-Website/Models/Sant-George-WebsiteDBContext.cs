using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sant_George_Website.Models
{
    public class Sant_George_WebsiteDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Answer>Answers{ get; set; }
        public DbSet<Exam >Exams { get; set; }
        public DbSet<Question >Questions { get; set; }
        public DbSet<Student_Answer_Choose >Student_Answer_Choose { get; set; }
        public DbSet<Student_Answer_Text >Student_Answer_Text { get; set; }
        public DbSet<Student_Assigned_Exam >Student_Assigned_Exam { get; set; }
        public DbSet<Teacher_Mark_Exam >Teacher_Mark_Exam { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
