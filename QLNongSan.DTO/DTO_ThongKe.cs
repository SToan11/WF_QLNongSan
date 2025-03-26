using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DTO
{
    public class DTO_ThongKe
    {
        public class SanPhamThongKeDTO
        {
            public string MaSanPham { get; set; }
            public string TenSanPham { get; set; }
            public string LoaiSanPham { get; set; }
            public int SoLuongTon { get; set; }
            public decimal DonGia { get; set; }
            public decimal TongGiaTriTon { get; set; }
        }
    }
}
