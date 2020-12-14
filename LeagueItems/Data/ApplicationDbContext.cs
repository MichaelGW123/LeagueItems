using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LeagueItems.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Champion> Champion { get; set; }
        public virtual DbSet<CustomList> CustomList { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Champion>(entity =>
            {
                entity.Property(e => e.Attacktype).IsFixedLength();

                entity.Property(e => e.Damagetype).IsFixedLength();
            });

            modelBuilder.Entity<CustomList>(entity =>
            {
                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.CustomList)
                    .HasForeignKey(d => d.ChampionId)
                    .HasConstraintName("FK_CustomList_Champion");

                entity.HasOne(d => d.EquipmentId1Navigation)
                    .WithMany(p => p.CustomListEquipmentId1Navigation)
                    .HasForeignKey(d => d.EquipmentId1)
                    .HasConstraintName("FK_CustomList_Equipment");

                entity.HasOne(d => d.EquipmentId2Navigation)
                    .WithMany(p => p.CustomListEquipmentId2Navigation)
                    .HasForeignKey(d => d.EquipmentId2)
                    .HasConstraintName("FK_CustomList_Equipment1");

                entity.HasOne(d => d.EquipmentId3Navigation)
                    .WithMany(p => p.CustomListEquipmentId3Navigation)
                    .HasForeignKey(d => d.EquipmentId3)
                    .HasConstraintName("FK_CustomList_Equipment2");

                entity.HasOne(d => d.EquipmentId4Navigation)
                    .WithMany(p => p.CustomListEquipmentId4Navigation)
                    .HasForeignKey(d => d.EquipmentId4)
                    .HasConstraintName("FK_CustomList_Equipment3");

                entity.HasOne(d => d.EquipmentId5Navigation)
                    .WithMany(p => p.CustomListEquipmentId5Navigation)
                    .HasForeignKey(d => d.EquipmentId5)
                    .HasConstraintName("FK_CustomList_Equipment4");

                entity.HasOne(d => d.EquipmentId6Navigation)
                    .WithMany(p => p.CustomListEquipmentId6Navigation)
                    .HasForeignKey(d => d.EquipmentId6)
                    .HasConstraintName("FK_CustomList_Equipment5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
