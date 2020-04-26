using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eQuanLyNhanSu.Data.Entities
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNv { get; set; }
        public string GioiTinh { get; set; }
        public string ChucVu { get; set; }
        public int CMND { get; set; }
        public DateTime NgaySinh { get; set; }
        public int MaPb { get; set; }
        public PhongBan PhongBan { get; set; }
        public Luong Luong { get; set; }
        public HopDong HopDong { get; set; }
    }
}
