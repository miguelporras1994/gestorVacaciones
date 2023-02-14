using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAcccesLayer.Models;

public partial class GestorvacacionesContext : DbContext
{
    public GestorvacacionesContext()
    {
    }

    public GestorvacacionesContext(DbContextOptions<GestorvacacionesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bedroom> Bedrooms { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<PriceBedroom> PriceBedrooms { get; set; }

    public virtual DbSet<Season> Seasons { get; set; }

    public virtual DbSet<TypeBedroom> TypeBedrooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=gestorvacaciones;User ID=miguel;Password=miguel123; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bedroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bedrooms__3214EC073124D1BC");

            entity.HasOne(d => d.IdHotelNavigation).WithMany(p => p.Bedrooms)
                .HasForeignKey(d => d.IdHotel)
                .HasConstraintName("FK__Bedrooms__IdHote__5165187F");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Bedrooms)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK__Bedrooms__Type__5070F446");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__City__3214EC0743D06EC8");

            entity.ToTable("City");

            entity.Property(e => e.NameCity)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hotel__3214EC071763CFD8");

            entity.ToTable("Hotel");

            entity.Property(e => e.NameHotel)
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.HasOne(d => d.IdcityNavigation).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.Idcity)
                .HasConstraintName("FK__Hotel__Idcity__4BAC3F29");
        });

        modelBuilder.Entity<PriceBedroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__priceBed__3214EC07962D9A4A");

            entity.ToTable("priceBedrooms");

            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.IdBedroomsNavigation).WithMany(p => p.PriceBedrooms)
                .HasForeignKey(d => d.IdBedrooms)
                .HasConstraintName("FK__priceBedr__price__5629CD9C");

            entity.HasOne(d => d.IdSeasonNavigation).WithMany(p => p.PriceBedrooms)
                .HasForeignKey(d => d.IdSeason)
                .HasConstraintName("FK__priceBedr__IdSea__571DF1D5");
        });

        modelBuilder.Entity<Season>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__season__3214EC07FE1F0A16");

            entity.ToTable("season");

            entity.Property(e => e.NameSeason)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TypeBedroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeBedr__3214EC070751C98C");

            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
