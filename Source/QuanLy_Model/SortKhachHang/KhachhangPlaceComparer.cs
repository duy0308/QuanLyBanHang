using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Model.SortKhachHang
{
    public class KhachhangPlaceComparer:IComparer<KhachHang>
    {
        public int Compare(KhachHang x, KhachHang y)
        {
            return x.DiaChi.CompareTo(y.DiaChi);
        }
    }
}
