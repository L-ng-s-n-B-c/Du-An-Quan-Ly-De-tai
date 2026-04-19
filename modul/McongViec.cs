using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Models
{
    public class CongViec
    {
        [Key]
        public int Id { get; set; }
        public string Ten { get; set; }
        public int? IdDuAn { get; set; }
        public int? IdNguoiGiao { get; set; }
        public int? IdNguoiNhan { get; set; }
        public string MoTa { get; set; }
        public string ThoiGianLamViec { get; set; }
        public string TrangThai { get; set; }
        public int? TienDo { get; set; }
    }
}