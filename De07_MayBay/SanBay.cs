using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De07_MayBay
{
    class SanBay
    {
        private string maMayBay;
        private string tenMayBay;
        private int namSanXuat;
        private string hangSanXuat;
        private string khuVucDo;

        public string MaMayBay { get => maMayBay; set => maMayBay = value; }
        public string TenMayBay { get => tenMayBay; set => tenMayBay = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
        public string KhuVucDo { get => khuVucDo; set => khuVucDo = value; }
    }
}
