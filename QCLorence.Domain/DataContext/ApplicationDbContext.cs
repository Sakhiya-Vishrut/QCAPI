using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using QCLorence.Domain.DataModel;

namespace QCLorence.Domain.DataContext;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inspectionplace> Inspectionplaces { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("User ID=postgres;Password=123;Server=localhost;Port=5432;Database=QCLorence;Pooling=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inspectionplace>(entity =>
        {
            entity.HasKey(e => e.InspectionplaceId).HasName("Inspectionplace_pkey");

            entity.ToTable("Inspectionplace");

            entity.Property(e => e.InspectionplaceId).HasColumnName("InspectionplaceID");
            entity.Property(e => e.CreatedDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.DeletedDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.Description).HasColumnType("character varying");
            entity.Property(e => e.ModifiedDate).HasColumnType("timestamp without time zone");
            entity.Property(e => e.PlaseName).HasColumnType("character varying");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
