using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Models
{
    public class SanPham
    {
        [Key]
        [Required]
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public string DonGia { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
