using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FadokoBackendV4.Models
{
    public partial class vizsgaremek_v4Context : DbContext
    {
        public vizsgaremek_v4Context()
        {
        }

        public vizsgaremek_v4Context(DbContextOptions<vizsgaremek_v4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=vizsgaremek_v4;user=root;password=;ssl mode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdId)
                    .HasName("PRIMARY");

                entity.ToTable("admin");

                entity.HasIndex(e => e.AdName, "AdName")
                    .IsUnique();

                entity.HasIndex(e => e.AdName, "AdName_2")
                    .IsUnique();

                entity.Property(e => e.AdId).HasColumnType("int(11)");

                entity.Property(e => e.Active).HasColumnType("int(2)");

                entity.Property(e => e.AdEmail)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.AdName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.AdPermission)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AdPhone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrId)
                    .HasName("PRIMARY");

                entity.ToTable("orders");

                entity.HasIndex(e => e.AdId, "CuId");

                entity.Property(e => e.OrId).HasColumnType("int(11)");

                entity.Property(e => e.AdId)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OrData)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AdId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("orders_ibfk_1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PrId)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.HasIndex(e => e.PrName, "PrName")
                    .IsUnique();

                entity.Property(e => e.PrId).HasColumnType("int(11)");

                entity.Property(e => e.PrActive).HasColumnType("int(2)");

                entity.Property(e => e.PrName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.PrOther)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.PrPrice).HasColumnType("int(6)");


                entity.Property(e => e.PrUrl)
                    .IsRequired()
                    .HasColumnType("mediumblob");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
