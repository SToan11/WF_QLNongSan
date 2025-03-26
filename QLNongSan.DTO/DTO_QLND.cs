using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_QLND
    {
        private string tenNguoiDung;
        private string gioiTinh;
        private string diaChi;
        private int vaiTro;
        private int sdt;
        private string emailNd;
        private string matKhau;
        private string hinhanh;
        public string TenNguoiDung
        {
            get
            {
                return tenNguoiDung;
            }
            set
            {
                tenNguoiDung = value;
            }
        }
        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                gioiTinh = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return diaChi;
            }
            set
            {
                diaChi = value;
            }
        }
        public int VaiTro
        {
            get
            {
                return vaiTro;
            }
            set
            {
                vaiTro = value;
            }
        }
        public string EmailND
        {
            get
            {
                return emailNd;
            }
            set
            {
                emailNd = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public int SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }

        public string Hinh
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
            }
        }
        public DTO_QLND(string emailNd, string tenNd, string diaChi, int vaiTro, string gioitinh,int sdt, string hinhanh)
        {
            this.tenNguoiDung = tenNd;
            this.diaChi = diaChi;
            this.vaiTro = vaiTro;
            this.emailNd = emailNd;
            this.gioiTinh = gioitinh;
            this.hinhanh = hinhanh;
            this.sdt = sdt;
        }
        public DTO_QLND(string tenNd, string emailNd)
        {
            this.emailNd = emailNd;
            this.tenNguoiDung= tenNd;
        }
        public DTO_QLND()
        { }
    }
}
