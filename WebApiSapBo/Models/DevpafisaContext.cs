using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiSapBo.Models;

public partial class DevpafisaContext : DbContext
{
    public DevpafisaContext()
    {
    }

    public DevpafisaContext(DbContextOptions<DevpafisaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sociedad> Sociedads { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevPafisa");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Sociedad>(entity =>
        {
            entity.ToTable("Sociedad");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataBaseName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DataBaseServer)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LicensePort).HasMaxLength(10);
            entity.Property(e => e.LicenseServer)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PasswordDb)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("PasswordDB");
            entity.Property(e => e.PasswordSap)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("PasswordSAP");
            entity.Property(e => e.UserDb)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("UserDB");
            entity.Property(e => e.UserSap)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("UserSAP");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser);

            entity.Property(e => e.Iduser).HasColumnName("IDUSER");
            entity.Property(e => e.Estado).HasMaxLength(25);
            entity.Property(e => e.PasswSap)
                .HasMaxLength(150)
                .HasColumnName("PasswSAP");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.UserSap)
                .HasMaxLength(50)
                .HasColumnName("UserSAP");
            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
