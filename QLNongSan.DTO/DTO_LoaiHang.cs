using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_LoaiHang
    {
        public string MaLoaiHang { get; set; }
        public string TenLoaiHang { get; set; }

        public DTO_LoaiHang(string maLoaiHang, string tenLoaiHang)
        {
            this.MaLoaiHang = maLoaiHang;
            this.TenLoaiHang = tenLoaiHang;
        }

        public DTO_LoaiHang()
        { }
    }
}
