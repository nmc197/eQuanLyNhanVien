using System;
using System.Collections.Generic;
using System.Text;

namespace eQuanLyNhanSu.Data.Entities
{
    public class NhanVien
    {
        public int MaNV { set; get; }
        public string TenNv { set; get; }
        public string GioiTi{ set; get; }
        public string ChucVu{ set; get; }
        public int MaPb { set; get; }
        public int CMND { set; get; }
        public DateTime NgaySinh { set; get; }

    }
}
