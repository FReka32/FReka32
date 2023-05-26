using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Iskola.Models
{
    public partial class iskolaContext : DbContext
    {
        public iskolaContext()
        {
        }

        public iskolaContext(DbContextOptions<iskolaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Diakok> Diakoks { get; set; } = null!;
        public virtual DbSet<Iskolak> Iskolaks { get; set; } = null!;
        public virtual DbSet<Iskolalogok> Iskolalogoks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;database=iskola;user=root;password=;sslmode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diakok>(entity =>
            {
                entity.ToTable("diakok");

                entity.HasIndex(e => e.IskolaId, "IskolaId");

                entity.HasIndex(e => e.OktatasiAzonosito, "oktatasiAzonosito")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.IskolaId).HasColumnType("int(3)");

                entity.Property(e => e.Nev).HasMaxLength(40);

                entity.Property(e => e.OktatasiAzonosito)
                    .HasMaxLength(11)
                    .HasColumnName("oktatasiAzonosito");

                entity.Property(e => e.Osztaly).HasMaxLength(12);

                entity.Property(e => e.Tanev).HasMaxLength(9);

                entity.HasOne(d => d.Iskola)
                    .WithMany(p => p.Diakoks)
                    .HasPrincipalKey(p => p.IskolaId)
                    .HasForeignKey(d => d.IskolaId)
                    .HasConstraintName("diakok_ibfk_1");
            });

            modelBuilder.Entity<Iskolak>(entity =>
            {
                entity.ToTable("iskolak");

                entity.HasIndex(e => e.IskolaId, "IskolaId")
                    .IsUnique();

                entity.HasIndex(e => e.IskolaId, "IskolaId_2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(2)")
                    .HasColumnName("id");

                entity.Property(e => e.IskolaId).HasColumnType("int(3)");

                entity.Property(e => e.Nev)
                    .HasMaxLength(70)
                    .HasColumnName("nev");

                entity.Property(e => e.SmallLogo)
                    .HasColumnType("mediumblob")
                    .HasColumnName("smallLogo");
            });

            modelBuilder.Entity<Iskolalogok>(entity =>
            {
                entity.ToTable("iskolalogok");

                entity.HasIndex(e => e.IskolaId, "iskola_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(2)")
                    .HasColumnName("id");

                entity.Property(e => e.IskolaId)
                    .HasColumnType("int(3)")
                    .HasColumnName("iskola_id");

                entity.Property(e => e.Logo)
                    .HasColumnType("mediumblob")
                    .HasColumnName("logo");

                entity.HasOne(d => d.Iskola)
                    .WithOne(p => p.Iskolalogok)
                    .HasPrincipalKey<Iskolak>(p => p.IskolaId)
                    .HasForeignKey<Iskolalogok>(d => d.IskolaId)
                    .HasConstraintName("iskolalogok_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
