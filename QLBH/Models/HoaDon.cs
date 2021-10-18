using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class HoaDon
    {
        [Key]
        [Required]
        public int MaHD { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayLapHD { get; set; }
        public DateTime NgayNhanHang { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public SanPham SanPham { get; set; }
    }
}
