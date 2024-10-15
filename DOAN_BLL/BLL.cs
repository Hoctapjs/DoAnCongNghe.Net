using System.Data;
using DOAN_DAL;
using DOAN_DTO;
using System.IO;

namespace DOAN_BLL

{
    public class BLL
    {
        public DataTable GetAllSanPham()
        {
            DAL dal = new DAL();
            return dal.GetAllSanPham();
        }

        public DataTable GetAllDonHang()
        {
            DAL dal = new DAL();
            return dal.GetAllDonHang();
        }

        public DataTable GetAllChiTietDonHang()
        {
            DAL dal = new DAL();
            return dal.GetAllChiTietDonHang();
        }

        public DataTable GetAllKhachHang()
        {
            DAL dal = new DAL();
            return dal.GetAllKhachHang();
        }

        public DataTable GetAllNhanVien()
        {
            DAL dal = new DAL();
            return dal.GetAllNhanVien();
        }

        public DataTable GetAllNgayThangNam()
        {
            DAL dal = new DAL();
            return dal.GetAllNgayThangNam();
        }

        public DataTable GetAllThangNam()
        {
            DAL dal = new DAL();
            return dal.GetAllThangNam();
        }

        public DataTable GetAllNam()
        {
            DAL dal = new DAL();
            return dal.GetAllNam();
        }

        public DataTable GetAllNV_TEN_QUYEN()
        {
            DAL dal = new DAL();
            return dal.GetAllNV_TEN_QUYEN();
        }

        public float TongDoanhThuTheoNam(int nam)
        {
            DAL dal = new DAL();
            return dal.TongDoanhThuTheoNam(nam);
        }

        public float TongDoanhThuTheoThang(int thang)
        {
            DAL dal = new DAL();
            return dal.TongDoanhThuTheoThang(thang);
        }

        public float TongDoanhThuTheoNgay(string ngay)
        {
            DAL dal = new DAL();
            return dal.TongDoanhThuTheoNgay(ngay);
        }

        public int GetSoKhachHang()
        {
            DAL dal = new DAL();
            return dal.GetSoKhachHang();
        }

        public int GetSoSanPham()
        {
            DAL dal = new DAL();
            return dal.GetSoSanPham();
        }

        public int GetSoDonHang()
        {
            DAL dal = new DAL();
            return dal.GetSoDonHang();
        }

        //
        public bool ThemSanPham(SANPHAMDTO sp)
        {
            DAL dal = new DAL();
            return dal.ThemSanPham(sp);
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SANPHAMDTO sp)
        {
            DAL dal = new DAL();
            return dal.SuaSanPham(sp);
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSP)
        {
            DAL dal = new DAL();
            return dal.XoaSanPham(maSP);
        }

        // TẠM XONG SẢN PHẨM

        // BẮT ĐẦU KHÁCH HÀNG
        // Thêm khách hàng
        public bool ThemKhachHang(KHACHHANGDTO kh)
        {
            DAL dal = new DAL();
            return dal.ThemKhachHang(kh);
        }

        // Sửa khách hàng
        public bool SuaKhachHang(KHACHHANGDTO kh)
        {
            DAL dal = new DAL();
            return dal.SuaKhachHang(kh);
        }

        // Xóa khách hàng
        public bool XoaKhachHang(int maKH)
        {
            DAL dal = new DAL();
            return dal.XoaKhachHang(maKH);
        }

        // TẠM XONG KHÁCH HÀNG

        // BẮT ĐẦU NHÂN VIÊN
        // Thêm nhân viên
        public bool ThemNhanVien(NHANVIENDTO nv)
        {
            DAL dal = new DAL();
            return dal.ThemNhanVien(nv);
        }

        // Sửa nhân viên
        public bool SuaNhanVien(NHANVIENDTO nv)
        {
            DAL dal = new DAL();
            return dal.SuaNhanVien(nv);
        }

        // Xóa nhân viên
        public bool XoaNhanVien(int maNV)
        {
            DAL dal = new DAL();
            return dal.XoaNhanVien(maNV);
        }

        // TẠM XONG NHÂN VIÊN

        // BẮT ĐẦU ĐƠN HÀNG
        // Thêm đơn hàng
        public bool ThemDonHang(DONHANGDTO dh)
        {
            DAL dal = new DAL();
            return dal.ThemDonHang(dh);
        }

        // Sửa đơn hàng
        public bool SuaDonHang(DONHANGDTO dh)
        {
            DAL dal = new DAL();
            return dal.SuaDonHang(dh);
        }

        // Xóa đơn hàng
        public bool XoaDonHang(int maDH)
        {
            DAL dal = new DAL();
            return dal.XoaDonHang(maDH);
        }

        // TẠM XONG ĐƠN HÀNG

        // BẮT ĐẦU CHI TIẾT ĐƠN HÀNG
        // Thêm chi tiết đơn hàng
        public bool ThemChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            DAL dal = new DAL();
            return dal.ThemChiTietDonHang(ct);
        }

        // Sửa chi tiết đơn hàng
        public bool SuaChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            DAL dal = new DAL();
            return dal.SuaChiTietDonHang(ct);
        }

        // Xóa chi tiết đơn hàng
        public bool XoaChiTietDonHang(int maDH, int maSP)
        {
            DAL dal = new DAL();
            return dal.XoaChiTietDonHang(maDH, maSP);
        }

        // TẠM XONG CHI TIẾT ĐƠN HÀNG

        // ĐẾN VỚI LOGIN
        // Phương thức kiểm tra đăng nhập
        public NHANVIENDTO KiemTraDangNhap(string username, string password)
        {
            DAL dal = new DAL();
            return dal.KiemTraDangNhap(username, password);
        }



    }
}