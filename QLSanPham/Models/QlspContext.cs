using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QLSanPham.Models;

public partial class QlspContext : DbContext
{
    public QlspContext()
    {
    }

    public QlspContext(DbContextOptions<QlspContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dmsanpham> Dmsanphams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-PEK7Q30\\SQLEXPRESS;Initial Catalog=qlsp;Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dmsanpham>(entity =>
        {
            entity.HasKey(e => e.Masanpham).HasName("PK__DMSANPHA__8F121B2FB5C81CDF");

            entity.ToTable("DMSANPHAM");

            entity.Property(e => e.Masanpham)
                .ValueGeneratedNever()
                .HasColumnName("masanpham");
            entity.Property(e => e.Dongia).HasColumnName("dongia");
            entity.Property(e => e.Maloai).HasColumnName("maloai");
            entity.Property(e => e.Soluong).HasColumnName("soluong");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tensanpham");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
