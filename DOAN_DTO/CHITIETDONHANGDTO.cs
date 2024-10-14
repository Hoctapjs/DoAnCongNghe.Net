using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_DTO
{
    public class CHITIETDONHANGDTO
    {
        public int MADH { get; set; }      // Mã đơn hàng
        public int MASP { get; set; }      // Mã sản phẩm
        public int SOLUONG { get; set; }   // Số lượng sản phẩm
        public decimal GIA { get; set; }   // Giá của sản phẩm
    }
}
