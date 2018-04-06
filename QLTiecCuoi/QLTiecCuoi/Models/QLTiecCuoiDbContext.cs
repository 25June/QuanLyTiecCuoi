namespace QLTiecCuoi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLTiecCuoiDbContext : DbContext
    {
        public QLTiecCuoiDbContext()
            : base("name=QLyTiecCuoi")
        {
        }

        public virtual DbSet<CTDichVu> CTDichVu { get; set; }
        public virtual DbSet<CTMonAn> CTMonAn { get; set; }
        public virtual DbSet<DichVu> DichVu { get; set; }
        public virtual DbSet<DoanhSo> DoanhSoe { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LoaiCa> LoaiCa { get; set; }
        public virtual DbSet<LoaiSanh> LoaiSanh { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        public virtual DbSet<Sanh> Sanh { get; set; }
        public virtual DbSet<sysdiagram> sysdiagram { get; set; }
        public virtual DbSet<ThamSo> ThamSoe { get; set; }
        public virtual DbSet<TiecCuoi> TiecCuoi { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CTDichVu>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<CTDichVu>()
                .Property(e => e.MaTiecCuoi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTDichVu>()
                .Property(e => e.SoLuong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTMonAn>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<CTMonAn>()
                .Property(e => e.MaTiecCuoi)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.CTDichVus)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaTiecCuoi)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiCa>()
                .Property(e => e.MaCa)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanh>()
                .Property(e => e.MaLoaiSanh)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .Property(e => e.MaMonAn)
                .IsUnicode(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.CTMonAns)
                .WithRequired(e => e.MonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sanh>()
                .Property(e => e.MaSanh)
                .IsUnicode(false);

            modelBuilder.Entity<Sanh>()
                .Property(e => e.MaLoaiSanh)
                .IsUnicode(false);

            modelBuilder.Entity<ThamSo>()
                .Property(e => e.MaTS)
                .IsUnicode(false);

            modelBuilder.Entity<ThamSo>()
                .Property(e => e.GiaTri)
                .IsUnicode(false);

            modelBuilder.Entity<ThamSo>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .Property(e => e.MaTiecCuoi)
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .Property(e => e.MaCa)
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .Property(e => e.MaSanh)
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .Property(e => e.SoBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .Property(e => e.SoBanDuTru)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TiecCuoi>()
                .HasMany(e => e.CTDichVus)
                .WithRequired(e => e.TiecCuoi)
                .HasForeignKey(e => e.MaDV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiecCuoi>()
                .HasMany(e => e.CTMonAns)
                .WithRequired(e => e.TiecCuoi)
                .WillCascadeOnDelete(false);
        }
    }
}
