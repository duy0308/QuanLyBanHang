using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Model.SortNhanVien
{
    public class NhanVienNameComparer: IComparer<NhanVien>
    {
        public int Compare(NhanVien x, NhanVien y)
        {
            return x.HoTen.CompareTo(y.HoTen);
        }
    }
}
