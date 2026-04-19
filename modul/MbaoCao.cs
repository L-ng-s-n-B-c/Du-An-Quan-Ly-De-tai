using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Models
{
    public class BaoCao
    {
        [Key]
        public string Ten { get; set; }
        public int? IdCongViec { get; set; }
        public string NoiDung { get; set; }
        public int? TienDo { get; set; }
        public DateTime? NgayNop { get; set; }
        public string LoaiBC { get; set; }
    }
}