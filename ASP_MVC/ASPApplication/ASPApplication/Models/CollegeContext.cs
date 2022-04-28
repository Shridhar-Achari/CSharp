using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPApplication.Models
{
    public partial class CollegeContext : DbContext
    {
        public CollegeContext()
        {
        }

        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlServer("DefaultConnection");
        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=LENOVOPC\\SQLEXPRESS;Database=College;Trusted_Connection=True;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.Course)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("course");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sname)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("sname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
