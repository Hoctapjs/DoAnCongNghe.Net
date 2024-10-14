using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_DTO
{
    public class SANPHAMDTO
    {
        public int MASP { get; set; } // Mã sản phẩm
        public string TENSP { get; set; } // Tên sản phẩm
        public decimal GIA { get; set; } // Giá sản phẩm
        public string KICHTHUOC { get; set; } // Kích thước sản phẩm
        public string TOPPING { get; set; } // Topping của sản phẩm
    }
}
