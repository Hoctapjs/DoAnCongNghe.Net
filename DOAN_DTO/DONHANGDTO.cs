using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_DTO
{
    public class DONHANGDTO
    {
        public int MADH { get; set; }           // Mã đơn hàng
        public int MAKH { get; set; }           // Mã khách hàng
        public string NGAYLAP { get; set; }   // Ngày lập đơn hàng
        public decimal TONGGIA { get; set; }    // Tổng giá trị đơn hàng
    }
}
