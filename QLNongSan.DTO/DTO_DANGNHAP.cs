using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_DANGNHAP
    {
        private int id_nd;
        private string manguoidung;
        private string tennguoidung;
        private string gioitinh;
        private string diachi;
        private string sdt;

        private string email;
        private string matkhau;
        private int vaitro;

        public int Id_nd
        {
            get { return id_nd; }
            set { id_nd = value; }
        }

        public string Manguoidung
        {
            get { return manguoidung; }
            set { manguoidung = value; }
        }

        public string Tennguoidung
        {
            get { return tennguoidung; }
            set { tennguoidung = value; }
        }

        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public int Vaitro
        {
            get { return vaitro; }
            set { vaitro = value; }
        }



        public DTO_DANGNHAP(int id_nguoi, string manguoidung, string tennguoidung, string gioitinh, string diachi, string sdt, string email, string matkhau, int vaitro)
        {
            this.id_nd = id_nguoi;
            this.manguoidung = manguoidung;
            this.tennguoidung = tennguoidung;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.Sdt = sdt;
            this.Email = email;
            this.matkhau = matkhau;
            this.vaitro = vaitro;

        }

        public DTO_DANGNHAP(int id_nguoi, string manguoidung, string tennguoidung, string gioitinh, string diachi, string sdt, string email, int vaitro)
        {
            this.id_nd = id_nguoi;
            this.manguoidung = manguoidung;
            this.tennguoidung = tennguoidung;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.Sdt = sdt;
            this.Email = email;

            this.vaitro = vaitro;

        }

        public DTO_DANGNHAP() { }
    }
}
