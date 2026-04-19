using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Models
{
    public class NhatKyTraoDoi
    {
        [Key]
        public int Id { get; set; }
        public int? IdCongViec { get; set; }
        public int? IdNguoiGui { get; set; }
        public string NoiDung { get; set; }
        public DateTime? ThoiGian { get; set; }
        public string FileDinhKem { get; set; }
    }
}