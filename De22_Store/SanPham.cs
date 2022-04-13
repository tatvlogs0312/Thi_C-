using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De22_Store
{
    class SanPham
    {
        private string maSanPham;
        private string tenSanPham;
        private int soLuongTon;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;
        private string nhaCungCap;

        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }
        public DateTime NgayHetHan { get => ngayHetHan; set => ngayHetHan = value; }
        public string NhaCungCap { get => nhaCungCap; set => nhaCungCap = value; }
    }
}
