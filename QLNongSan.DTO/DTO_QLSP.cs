using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLSP
{
    public class DTO_QLSanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private int soLuong;
        private float donGia;
        private string hinhAnh;
        private string ghiChu;
        private string loaiSanPham;
        private string maLoaiSanPham;
        private DateTime ngayThem;

        public DateTime NgayThem
        {
            get
            {
                return ngayThem;
            }
            set
            {
                ngayThem = value;
            }
        }

        public string MaSanPham
        {
            get
            {
                return maSanPham;
            }
            set
            {
                maSanPham = value;
            }
        }
        public string TenSanPham
        {
            get
            {
                return tenSanPham;
            }
            set
            {
                tenSanPham = value;
            }
        }
        public int SoLuong
        {
            get
            {
                return soLuong;
            }
            set
            {
                soLuong = value;
            }
        }
        public float DonGia
        {
            get
            {
                return donGia;
            }
            set
            {
                donGia = value;
            }
        }

        public string HinhAnh
        {
            get
            {
                return hinhAnh;
            }
            set
            {
                hinhAnh = value;
            }
        }
        public string GhiChu
        {
            get
            {
                return ghiChu;
            }
            set
            {
                ghiChu = value;
            }
        }
        public string LoaiSanPham
        {
            get
            {
                return loaiSanPham;
            }
            set
            {
                loaiSanPham = value;
            }
        }
        public string MaLoaiSanPham
        {
            get
            {
                return maLoaiSanPham;
            }
            set
            {
                maLoaiSanPham = value;
            }
        }

        public DTO_QLSanPham(string tenSanPham, string loaiSanPham)
        {
            this.tenSanPham = tenSanPham;
            this.loaiSanPham = loaiSanPham;
        }
        public DTO_QLSanPham(string maSanPham, string tenSanPham, int soLuong, float donGia, DateTime ngayThem,
                        string hinhAnh,string maloaiSanPham, string ghiChu)
        {
            this.maSanPham = maSanPham;
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.ngayThem = ngayThem;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.maLoaiSanPham = maloaiSanPham;
        }
        public DTO_QLSanPham(string tenSanPham, int soLuong, float donGia, DateTime ngayThem,
                        string hinhAnh, string maloaiSanPham, string ghiChu, string loaiSanPham)
        {
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.ngayThem = ngayThem;
            this.hinhAnh = hinhAnh;
            this.ghiChu = ghiChu;
            this.loaiSanPham = loaiSanPham;
            this.maLoaiSanPham = maloaiSanPham;
        }
    }
}
