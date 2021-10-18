using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class NhanVien
    {
        [Key]
        [Required]
        public int MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set;}
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int DienThoai { get; set; }
        public ICollection <HoaDon> HoaDons { get; set; }
    }
}
