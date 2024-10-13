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
    }
}