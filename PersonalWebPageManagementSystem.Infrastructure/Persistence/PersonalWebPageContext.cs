using Microsoft.EntityFrameworkCore;
using PersonalWebPageManagementSystem.Domain.Entities;

namespace PersonalWebPageManagementSystem.Infrastructure.Persistence
{
    public class PersonalWebPageContext : DbContext
    {
        public PersonalWebPageContext(DbContextOptions<PersonalWebPageContext> options)
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
            // Resume entity configuration
            modelBuilder.Entity<Resume>(entity =>
            {
                entity.ToTable("Resume");
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);
                
                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);
                
                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500);
                
                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            // ResumeProfile entity configuration
            modelBuilder.Entity<ResumeProfile>(entity =>
            {
                entity.ToTable("ResumeProfile");
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);
                
                entity.HasOne(e => e.Resume)
                    .WithOne(r => r.Profile)
                    .HasForeignKey<ResumeProfile>(e => e.ResumeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // ResumeExperience entity configuration
            modelBuilder.Entity<ResumeExperience>(entity =>
            {
                entity.ToTable("ResumeExperience");
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.Employer)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.HasOne(e => e.Resume)
                    .WithMany(r => r.EmploymentHistory)
                    .HasForeignKey(e => e.ResumeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // ResumeEducation entity configuration
            modelBuilder.Entity<ResumeEducation>(entity =>
            {
                entity.ToTable("ResumeEducation");
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Institution)
                    .IsRequired()
                    .HasMaxLength(200);
                
                entity.Property(e => e.Degree)
                    .HasMaxLength(200);
                
                entity.Property(e => e.FieldOfStudy)
                    .HasMaxLength(200);
                
                entity.HasOne(e => e.Resume)
                    .WithMany(r => r.Education)
                    .HasForeignKey(e => e.ResumeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // ResumeSkill entity configuration
            modelBuilder.Entity<ResumeSkill>(entity =>
            {
                entity.ToTable("ResumeSkill");
                entity.HasKey(e => e.Id);
                
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
                
                entity.Property(e => e.Description)
                    .HasMaxLength(500);
                
                entity.HasOne(e => e.Resume)
                    .WithMany(r => r.Skills)
                    .HasForeignKey(e => e.ResumeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
