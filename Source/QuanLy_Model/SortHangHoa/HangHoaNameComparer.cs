using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_Model.SortHangHoa
{
    public class HangHoaNameComparer : IComparer<HangHoa>
    {
        public int Compare(HangHoa x, HangHoa y)
        {
            return x.TenHH.CompareTo(y.TenHH);
        }
    }
}
