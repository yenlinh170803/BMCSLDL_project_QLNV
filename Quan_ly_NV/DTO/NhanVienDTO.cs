using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_ly_NV.DTO
{
    internal class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }

        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public double Luong { get; set; }
        public double PhuCap { get; set; }
        public string VaiTro { get; set; }
        public string MaNQL { get; set; }
        public string MaPB { get; set; }
    }
}
