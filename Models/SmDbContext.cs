using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace studentmangment2022.Models
{
    public partial class SmDbContext : DbContext
    {
        public SmDbContext()
        {
        }

        public SmDbContext(DbContextOptions<SmDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=LAPTOP-4LUAPHVB\\SQLEXPRESS;Database=SmDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Regno)
                    .HasName("PK__Student__2C6EFDC0BC7C1B9B");

                entity.HasIndex(e => e.EmailId)
                    .HasName("UQ__Student__7ED91ACEA5E5CFA8")
                    .IsUnique();

                entity.HasIndex(e => e.MobileNumber)
                    .HasName("UQ__Student__C892EBD62E41050A")
                    .IsUnique();

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasColumnName("BatchID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CourseFee)
                    .HasColumnName("Course_Fee")
                    .HasColumnType("numeric(8, 2)");

                entity.Property(e => e.CourseJoin)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Doj)
                    .HasColumnName("DOJ")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasColumnName("Mobile_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.StudentFullName)
                    .IsRequired()
                    .HasColumnName("Student_Full_Name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
