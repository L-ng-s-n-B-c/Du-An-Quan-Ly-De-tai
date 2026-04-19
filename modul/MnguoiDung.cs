using System;
using System.ComponentModel.DataAnnotations; // Dùng để đặt Khóa chính

namespace QuanLyDuAn.Models // Tên thư mục chứa code của em
{
    public class NguoiDung
    {
        [Key] // Dòng này báo cho C# biết Id chính là Khóa chính (Primary Key)
        public int Id { get; set; }

        public string TaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public string Ten { get; set; }

        public string ChucVu { get; set; }

        public string Email { get; set; }

        public string SDT { get; set; }

        public string VaiTro { get; set; }

        public string TrangThai { get; set; }
    }
}