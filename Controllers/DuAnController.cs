using Microsoft.AspNetCore.Mvc;
using QuanLyDuAnDetai.modul; 
using System.Linq;

namespace QuanLyDuAnDetai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuAnController : ControllerBase
    {
        // 1. Gọi cái "Cây cầu" (DbContext) ra đây để chuẩn bị dùng
        private readonly ApplicationDbContext _context;

        public DuAnController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==========================================
        // HÀNH ĐỘNG 1: Lấy toàn bộ danh sách Dự Án
        // ==========================================
        [HttpGet]
        public IActionResult LayDanhSachDuAn()
        {
            // Bảo DbContext chạy vào kho, gom hết bảng DuAn ra thành một danh sách (List)
            var danhSach = _context.DuAn.ToList();

            // Trả về cho frontend với mã 200 (Thành công)
            return Ok(danhSach);
        }
    }
}