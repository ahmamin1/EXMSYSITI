using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSys.Models
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext() { }
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentsExams> StudentsExams { get; set; }
        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entityEntry in entities)
            {
                var now = DateTime.UtcNow;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedAt = now;
                }

                ((BaseEntity)entityEntry.Entity).UpdatedAt = now;
            }

            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //amin
                optionsBuilder.UseSqlServer("Server=AMIN\\SQLEXPRESS;Database=ExamSystem;Trusted_Connection=True;\nTrustServerCertificate=True;");
                //ibrahem
                //optionsBuilder.UseSqlServer("Server=DESKTOP-C90KJR9\\SQLEXPRESS;Database=ExamSystem;Trusted_Connection=True;\nTrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentsExams>().HasKey(se => new { se.StudentId, se.ExamId });
            modelBuilder.Entity<StudentsExams>()
        .HasOne(se => se.Student)
        .WithMany(s => s.StudentsExams)
        .HasForeignKey(se => se.StudentId)
        .OnDelete(DeleteBehavior.NoAction); // Specify ON DELETE NO ACTION
        }


    }
}
