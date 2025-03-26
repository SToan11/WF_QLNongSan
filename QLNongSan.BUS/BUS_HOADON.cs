using QLNongSan.DAL;
using QLNongSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.BUS
{
    public class BUS_HOADON
    {
        DAL_HoaDon DAL_HoaDon = new DAL_HoaDon();
        public DataTable dssanpham()
        {
            return DAL_HoaDon.dssanpham();
        }
        public DataTable dsnhanvien()
        {
            return DAL_HoaDon.dsnhanvien();
        }
        public DataTable dskhachhang()
        {
            return DAL_HoaDon.dskhachhang();
        }
        public DataRow thongTinSanPham(string masp)
        {
            return DAL_HoaDon.thongTinSanPham(masp);
        }
        public DataRow thongTinNguoiDung(string manv)
        {
            return DAL_HoaDon.thongTinNhanVien(manv);
        }
        public DataRow thongTinKhachHang(string makh)
        {
            return DAL_HoaDon.thongTinKhachHang(makh);
        }
        public DataTable DanhSachHoaDon(int sotrang, int kichthuoctrang)
        {
            return DAL_HoaDon.DanhSachHoaDon(sotrang, kichthuoctrang);
        }
        public int getTongHoaDon()
        {
            return DAL_HoaDon.getTongHoaDon();
        }
        public bool taoHoaDon(string manv, DateTime ngayban, string makh)
        {
            return DAL_HoaDon.taoHoaDon(manv, ngayban, makh);
        }
        public bool deleteHoaDon(string mahoadon)
        {
            return DAL_HoaDon.deleteHoaDon(mahoadon);
        }

        public bool suaHoaDon(string mahd, string manv, DateTime ngayban, string makh, float tongtien)
        {
            return DAL_HoaDon.suaHoaDon(mahd,manv,ngayban,makh,tongtien);
        }
        public bool themSanPhamHoaDon(DTO_HoaDon hd)
        {
            return DAL_HoaDon.themSanPhamHoaDon(hd);
        }
        public bool capNhatTongTien(string mahd, float tongtien)
        {
            return DAL_HoaDon.capNhatTongTien(mahd, tongtien);
        }
        public bool suaSanPhamHoaDon(string mahd, string masp, string tensp, string loaisp, int soluong, string dongia, float thanhtien)
        {
            return DAL_HoaDon.suaSanPhamHoaDon(mahd,masp,tensp,loaisp,soluong,dongia,thanhtien);
        }
        public bool xoaSanPhamHoaDon(string mahd, string masp)
        {
            return DAL_HoaDon.xoaSanPhamHoaDon(mahd, masp);
        }
        public DataTable DanhSachSanPhamHoaDon(string mahd)
        {
            return DAL_HoaDon.DanhSachSanPhamHoaDon(mahd);
        }
        public DataTable searchSanPhamHoaDon(string mahd, string tensp)
        {
            return DAL_HoaDon.searchSanPhamHoaDon(mahd, tensp);
        }

        public bool truSoLuong(string masp, int soluong)
        {
            return DAL_HoaDon.truSoLuong(masp, soluong);
        }
        public bool congSoLuong(string masp, int soluong)
        {
            return DAL_HoaDon.congSoLuong(masp, soluong);
        }

        public int laySoLuongHienTai(string masp)
        {
            return DAL_HoaDon.LaySoLuongHienTai(masp);
        }

        public bool kiemTra(string masp, string mahd)
        {
            return DAL_HoaDon.kiemTra(masp,mahd);
        }
    }
}
