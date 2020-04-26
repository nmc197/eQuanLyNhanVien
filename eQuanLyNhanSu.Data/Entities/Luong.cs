using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eQuanLyNhanSu.Data.Entities
{
    public class Luong
    {
      public int MaNV { set; get; }
      public int MaLuong { set; get; }
      public decimal LuongCoBan { set; get; }
      public int SoNgayLam { set; get; }
      public decimal PhuCap { set; get; }
      public NhanVien NhanVien { set; get; }
       
    }
}
