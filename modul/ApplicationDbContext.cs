using Microsoft.EntityFrameworkCore;
using QuanLyDuAn.Models;
using System.Collections.Generic;

namespace QuanLyDuAnDetai.modul
{
    public class ApplicationDbContext : DbContext
    {
        // Trạm thu phí bắt buộc phải có của Cây cầu
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Đã xóa chữ M đi để khớp với ruột class của em
        public DbSet<NguoiDung> NguoiDung { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        public DbSet<CongViec> CongViec { get; set; }
        public DbSet<BaoCao> BaoCao { get; set; }
        public DbSet<NhatKyTraoDoi> NhatKyTraoDoi { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Giúp định dạng cột Ngân Sách cho chuẩn
            modelBuilder.Entity<DuAn>()
                .Property(p => p.NganSach)
                .HasColumnType("decimal(18,2)");
        }
    }
}