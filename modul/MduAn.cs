using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Models
{
    public class DuAn
    {
        [Key]
        public int Id { get; set; }

        // Thêm dấu ? vào sau string cho cả 4 dòng này
        public string? Ten { get; set; }
        public string? MoTa { get; set; }
        public string? DiaDiem { get; set; }
        public string? TrangThai { get; set; }

        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal? NganSach { get; set; }
        public int? IdNguoiTao { get; set; }
    }
}