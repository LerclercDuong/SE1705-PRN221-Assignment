using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BusinessObjects.Entities;

namespace BusinessObjects.Context
{
    public partial class KoiFishAdvertisementDBContext : DbContext
    {
        public KoiFishAdvertisementDBContext()
        {
        }

        public KoiFishAdvertisementDBContext(DbContextOptions<KoiFishAdvertisementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Advertisement> Advertisements { get; set; } = null!;
        public virtual DbSet<FengShuiElement> FengShuiElements { get; set; } = null!;
        public virtual DbSet<KoiFish> KoiFishes { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Database=KoiFishAdvertisementDB;Uid=sa;Pwd=123456;Trusted_Connection=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.HasIndex(e => e.Username, "UQ__Account__536C85E4453F66A9")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Account__A9D105346E5CA318")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.PasswordHash).HasMaxLength(255);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Account__RoleID__3C69FB99");
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.ToTable("Advertisement");

                entity.Property(e => e.AdvertisementId).HasColumnName("AdvertisementID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.KoiFishId).HasColumnName("KoiFishID");

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.KoiFish)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.KoiFishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Advertise__KoiFi__45F365D3");

                entity.HasOne(d => d.PostedByNavigation)
                    .WithMany(p => p.Advertisements)
                    .HasForeignKey(d => d.PostedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Advertise__Poste__46E78A0C");
            });

            modelBuilder.Entity<FengShuiElement>(entity =>
            {
                entity.HasKey(e => e.ElementId)
                    .HasName("PK__FengShui__A429723A8929D624");

                entity.ToTable("FengShuiElement");

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ElementName).HasMaxLength(50);
            });

            modelBuilder.Entity<KoiFish>(entity =>
            {
                entity.ToTable("KoiFish");

                entity.Property(e => e.KoiFishId).HasColumnName("KoiFishID");

                entity.Property(e => e.EnergyType).HasMaxLength(50);

                entity.Property(e => e.FengShuiElementId).HasColumnName("FengShuiElementID");

                entity.Property(e => e.KoiFishColor).HasMaxLength(50);

                entity.Property(e => e.KoiFishName).HasMaxLength(50);

                entity.Property(e => e.KoiFishSize).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Origin).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SymbolicMeaning).HasMaxLength(255);

                entity.HasOne(d => d.FengShuiElement)
                    .WithMany(p => p.KoiFishes)
                    .HasForeignKey(d => d.FengShuiElementId)
                    .HasConstraintName("FK__KoiFish__FengShu__412EB0B6");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
