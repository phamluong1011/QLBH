using QLBH.Models;
using System;
using System.Linq;

namespace QLBH.Data
{
    public static class DbInitializer
    {
        public static void Initialize(QLBHContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.NhanViens.Any())
            {
                return;   // DB has been seeded
            }

            var NhanViens = new NhanVien[]
            {
            new NhanVien{MaNV=01,HoNV="Alexander",TenNV="Truco",GioiTinh=true,NgaySinh=DateTime.Parse("2002-09-01"),DiaChi="DinhCong",DienThoai=0971043697 },
            new NhanVien{MaNV=01,HoNV="Athur",TenNV="Truco",GioiTinh=true,NgaySinh=DateTime.Parse("2002-09-01"),DiaChi="DinhCong",DienThoai=0971043697},
            new NhanVien{MaNV=03,HoNV="Tim",TenNV="Truco",GioiTinh=true,NgaySinh=DateTime.Parse("2002-09-01"),DiaChi="DinhCong",DienThoai=0971043697},
            new NhanVien{MaNV=04,HoNV="Jake",TenNV="Truco",GioiTinh=true,NgaySinh=DateTime.Parse("2002-09-01"),DiaChi="DinhCong",DienThoai=0971043697},
            };
            foreach (NhanVien n in NhanViens)
            {
                context.NhanViens.Add(n);
            }
            context.SaveChanges();

            var KhachHangs = new KhachHang[]
            {
               new KhachHang{ MaKH=01, HoTenKH="Lily",DiaChi="DinhCong",DienThoai=0912572155},
               new KhachHang{ MaKH=02, HoTenKH="Jille",DiaChi="DinhCong",DienThoai=0912572155},
               new KhachHang{ MaKH=03, HoTenKH="Chille",DiaChi="DinhCong",DienThoai=0912572155},
               new KhachHang{ MaKH=04, HoTenKH="Quill",DiaChi="DinhCong",DienThoai=0912572155},
               new KhachHang{ MaKH=05, HoTenKH="Dick",DiaChi="DinhCong",DienThoai=0912572155},
            };
            foreach (KhachHang k in KhachHangs)
            {
                context.KhachHangs.Add(k);
            }
            context.SaveChanges();

            var SanPhams = new SanPham[]
            {
                new SanPham{MaSP=01,TenSP="Bia",DonViTinh="Chai",DonGia="9000"},
                new SanPham{MaSP=02,TenSP="Coca",DonViTinh="Chai",DonGia="9000"},
                new SanPham{MaSP=03,TenSP="Pepsi",DonViTinh="Vỉ",DonGia="9000"},
                new SanPham{MaSP=04,TenSP="Fantasy",DonViTinh="Lon",DonGia="9000"},
            };
            foreach (SanPham s in SanPhams)
            {
                context.SanPhams.Add(s);
            }
            context.SaveChanges();
            var HoaDons = new HoaDon[]
            {
            new HoaDon{MaHD=1,MaKH=01,MaNV=01,MaSP=01,SoLuong=2,NgayLapHD=DateTime.Parse("2002-09-01"),NgayNhanHang=DateTime.Parse("2002-09-02")},
            new HoaDon{MaHD=2,MaKH=02,MaNV=02,MaSP=02,SoLuong=2,NgayLapHD=DateTime.Parse("2002-09-01"),NgayNhanHang=DateTime.Parse("2002-09-02")},
            new HoaDon{MaHD=3,MaKH=03,MaNV=01,MaSP=03,SoLuong=2,NgayLapHD=DateTime.Parse("2002-09-01"),NgayNhanHang=DateTime.Parse("2002-09-02")},
            new HoaDon{MaHD=4,MaKH=04,MaNV=01,MaSP=04,SoLuong=2,NgayLapHD=DateTime.Parse("2002-09-01"),NgayNhanHang=DateTime.Parse("2002-09-02")},
            new HoaDon{MaHD=5,MaKH=05,MaNV=01,MaSP=05,SoLuong=2,NgayLapHD=DateTime.Parse("2002-09-01"),NgayNhanHang=DateTime.Parse("2002-09-02")},
            };
            foreach (HoaDon h in HoaDons)
            {
                context.HoaDons.Add(h);
            }
            context.SaveChanges();

        }
    }
}