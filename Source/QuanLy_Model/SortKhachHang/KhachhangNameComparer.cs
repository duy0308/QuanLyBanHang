using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Model.SortKhachHang
{
    public class KhachhangNameComparer:IComparer <KhachHang>
    {
        public int Compare(KhachHang x, KhachHang y)
        {
            return x.HoTen.CompareTo(y.HoTen);
        }
    }
}
