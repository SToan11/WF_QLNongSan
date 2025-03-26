using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_HoTro
    {
        private int id;
        private string email;
        private string noiDung;
        private DateTime thoiGian;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }
        public DateTime ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        public DTO_HoTro(int iD, string Emailkh, string NoiDung, DateTime thoiGian)
        {
            this.ID = iD;
            this.email = Emailkh;
            this.noiDung = NoiDung;
            this.thoiGian = thoiGian;
        }
        public DTO_HoTro() { }
    }
}
