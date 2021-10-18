using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class KhachHang
    {
        [Key]
        [Required]
        public int MaKH { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChi { get; set; }
        public int DienThoai { get; set; }
        public  ICollection<HoaDon> HoaDons { get; set; }
   
    }
}
