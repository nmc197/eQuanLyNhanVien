using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.Entities
{
    public class HopDong
    {
        public int MaHD { set; get; }
        public int MaNV { set; get; }
        public int NgayBatDau { set; get; }
        public int NgayKetThuc { set; get; }

        public NhanVien NhanVien { set; get; }
    }
}
