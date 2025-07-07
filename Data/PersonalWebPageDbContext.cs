using Microsoft.EntityFrameworkCore;
using PersonalWebPageManagementSystem.Models;

namespace PersonalWebPageManagementSystem.Data
{
    public class PersonalWebPageContext : DbContext
    {
        public PersonalWebPageContext (DbContextOptions<PersonalWebPageContext> options)
            : base(options)
        {
        }

        public DbSet<Resume> Resume { get; set; }
        public DbSet<ResumeEducation> ResumeEducation { get; set; }
        public DbSet<ResumeExperience> ResumeExperience { get; set; }
        public DbSet<ResumeProfile> ResumeProfile { get; set; }
        public DbSet<ResumeSkill> ResumeSkill { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resume>().ToTable("Resume");
            modelBuilder.Entity<ResumeEducation>().ToTable("ResumeEducation");
            modelBuilder.Entity<ResumeExperience>().ToTable("ResumeExperience");
            modelBuilder.Entity<ResumeProfile>().ToTable("ResumeProfile");
            modelBuilder.Entity<ResumeSkill>().ToTable("ResumeSkill");
            
        }
    }
}