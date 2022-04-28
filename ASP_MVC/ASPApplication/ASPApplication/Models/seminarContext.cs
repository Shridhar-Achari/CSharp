using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASPApplication.Models
{
    public partial class seminarContext : DbContext
    {
        public seminarContext()
        {
        }

        public seminarContext(DbContextOptions<seminarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<NewCust> NewCusts { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning    To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LENOVOPC\\SQLEXPRESS;Database=seminar;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__A1B71F90853C6A0B");

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustAddr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_addr");

                entity.Property(e => e.CustAge).HasColumnName("cust_age");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");
            });

            modelBuilder.Entity<NewCust>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("new_cust");

                entity.Property(e => e.CustAddr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_addr");

                entity.Property(e => e.CustAge).HasColumnName("cust_age");

                entity.Property(e => e.CustId).HasColumnName("cust_id");

                entity.Property(e => e.CustName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cust_name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrdId)
                    .HasName("PK__Orders__DC39D7DF9F304363");

                entity.Property(e => e.OrdId).HasColumnName("ord_id");

                entity.Property(e => e.CId).HasColumnName("c_id");

                entity.Property(e => e.OrdDate)
                    .HasColumnType("date")
                    .HasColumnName("ord_date");

                entity.HasOne(d => d.CIdNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__Orders__c_id__4222D4EF");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__Products__82E06B916608ACD9");

                entity.Property(e => e.PId).HasColumnName("p_id");

                entity.Property(e => e.OId).HasColumnName("o_id");

                entity.Property(e => e.PrdName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("prd_name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.OIdNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.OId)
                    .HasConstraintName("FK__Products__o_id__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
