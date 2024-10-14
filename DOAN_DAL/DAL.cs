using System.Data;
using System.Data.SqlClient;
using DOAN_DTO;
using System.IO;

namespace DOAN_DAL
{
    public class DAL
    {
        private string connectionString = "Data Source=LAPTOP-2IRIHD28\\SQLSEVER2012;Initial Catalog=QL_TRASUA;Integrated Security=True";

        // get dataload
        public DataTable GetAllSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM SANPHAM";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM DONHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllChiTietDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CHITIETDONHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM KHACHHANG";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNV_TEN_QUYEN()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TENNV, QUYEN FROM NHANVIEN";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNgayThangNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FORMAT(NGAYLAP, 'yyyy-MM-dd') AS NgayThangNam FROM DONHANG;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllThangNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT FORMAT(NGAYLAP, 'MM') AS ThangNam FROM DONHANG;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable GetAllNam()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT YEAR(NGAYLAP) AS Nam FROM DONHANG GROUP BY YEAR(NGAYLAP)";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public float TongDoanhThuTheoNam(int nam)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) FROM DONHANG WHERE YEAR(NGAYLAP) = {nam}";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;

                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public float TongDoanhThuTheoThang(int thang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) AS TONGDOANHTHU FROM DONHANG WHERE MONTH(NGAYLAP) = {thang} AND YEAR(NGAYLAP) = YEAR(GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;

                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public float TongDoanhThuTheoNgay(string ngay)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT SUM(TONGGIA) FROM DONHANG WHERE NGAYLAP = '{ngay}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                float so = 0;
                decimal kq;
                try
                {
                    kq = (decimal)cmd.ExecuteScalar();
                    so = (float)kq;
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHACHHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM SANPHAM";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        public int GetSoDonHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DONHANG";
                SqlCommand cmd = new SqlCommand(query, conn);
                int so = 0;
                try
                {
                    so = (int)cmd.ExecuteScalar();
                }
                catch (Exception)
                {

                    throw;
                }
                return so;
            }
        }

        // Thêm sản phẩm
        public bool ThemSanPham(SANPHAMDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO SANPHAM (TENSP, GIA, KICHTHUOC, TOPPING) VALUES (@TENSP, @GIA, @KICHTHUOC, @TOPPING)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENSP", sp.TENSP);
                cmd.Parameters.AddWithValue("@GIA", sp.GIA);
                cmd.Parameters.AddWithValue("@KICHTHUOC", sp.KICHTHUOC ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TOPPING", sp.TOPPING ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa sản phẩm
        public bool SuaSanPham(SANPHAMDTO sp)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE SANPHAM SET TENSP = @TENSP, GIA = @GIA, KICHTHUOC = @KICHTHUOC, TOPPING = @TOPPING WHERE MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASP", sp.MASP);
                cmd.Parameters.AddWithValue("@TENSP", sp.TENSP);
                cmd.Parameters.AddWithValue("@GIA", sp.GIA);
                cmd.Parameters.AddWithValue("@KICHTHUOC", sp.KICHTHUOC ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TOPPING", sp.TOPPING ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa sản phẩm
        public bool XoaSanPham(int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM SANPHAM WHERE MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MASP", maSP);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM XONG SẢN PHẨM

        // BẮT ĐẦU KHÁCH HÀNG
        // Thêm khách hàng
        public bool ThemKhachHang(KHACHHANGDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO KHACHHANG (TENKH, SODT, DIACHI) VALUES (@TENKH, @SODT, @DIACHI)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENKH", kh.TENKH);
                cmd.Parameters.AddWithValue("@SODT", kh.SODT);
                cmd.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa khách hàng
        public bool SuaKhachHang(KHACHHANGDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE KHACHHANG SET TENKH = @TENKH, SODT = @SODT, DIACHI = @DIACHI WHERE MAKH = @MAKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", kh.MAKH);
                cmd.Parameters.AddWithValue("@TENKH", kh.TENKH);
                cmd.Parameters.AddWithValue("@SODT", kh.SODT);
                cmd.Parameters.AddWithValue("@DIACHI", kh.DIACHI ?? (object)DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa khách hàng
        public bool XoaKhachHang(int maKH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM KHACHHANG WHERE MAKH = @MAKH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", maKH);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM XONG KHÁCH HÀNG

        // BẮT ĐẦU NHÂN VIÊN
        // Thêm nhân viên
        public bool ThemNhanVien(NHANVIENDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO NHANVIEN (TENNV, QUYEN, USERNAME, PASSWORD) VALUES (@TENNV, @QUYEN, @USERNAME, @PASSWORD)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TENNV", nv.TENNV);
                cmd.Parameters.AddWithValue("@QUYEN", nv.QUYEN);
                cmd.Parameters.AddWithValue("@USERNAME", nv.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", nv.PASSWORD);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa nhân viên
        public bool SuaNhanVien(NHANVIENDTO nv)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE NHANVIEN SET TENNV = @TENNV, QUYEN = @QUYEN, USERNAME = @USERNAME, PASSWORD = @PASSWORD WHERE MANV = @MANV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANV", nv.MANV);
                cmd.Parameters.AddWithValue("@TENNV", nv.TENNV);
                cmd.Parameters.AddWithValue("@QUYEN", nv.QUYEN);
                cmd.Parameters.AddWithValue("@USERNAME", nv.USERNAME);
                cmd.Parameters.AddWithValue("@PASSWORD", nv.PASSWORD);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa nhân viên
        public bool XoaNhanVien(int maNV)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MANV", maNV);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM XONG NHÂN VIÊN

        // BẮT ĐẦU ĐƠN HÀNG
        // Thêm đơn hàng
        public bool ThemDonHang(DONHANGDTO dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO DONHANG (MAKH, NGAYLAP, TONGGIA) VALUES (@MAKH, @NGAYLAP, @TONGGIA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MAKH", dh.MAKH);
                cmd.Parameters.AddWithValue("@NGAYLAP", dh.NGAYLAP);
                cmd.Parameters.AddWithValue("@TONGGIA", dh.TONGGIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa đơn hàng
        public bool SuaDonHang(DONHANGDTO dh)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE DONHANG SET MAKH = @MAKH, NGAYLAP = @NGAYLAP, TONGGIA = @TONGGIA WHERE MADH = @MADH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", dh.MADH);
                cmd.Parameters.AddWithValue("@MAKH", dh.MAKH);
                cmd.Parameters.AddWithValue("@NGAYLAP", dh.NGAYLAP);
                cmd.Parameters.AddWithValue("@TONGGIA", dh.TONGGIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa đơn hàng
        public bool XoaDonHang(int maDH)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM DONHANG WHERE MADH = @MADH";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", maDH);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // TẠM KẾT THÚC ĐƠN HÀNG

        // BẮT ĐẦU CHI TIẾT ĐƠN HÀNG
        // Thêm chi tiết đơn hàng
        public bool ThemChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO CHITIETDONHANG (MADH, MASP, SOLUONG, GIA) VALUES (@MADH, @MASP, @SOLUONG, @GIA)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", ct.MADH);
                cmd.Parameters.AddWithValue("@MASP", ct.MASP);
                cmd.Parameters.AddWithValue("@SOLUONG", ct.SOLUONG);
                cmd.Parameters.AddWithValue("@GIA", ct.GIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Sửa chi tiết đơn hàng
        public bool SuaChiTietDonHang(CHITIETDONHANGDTO ct)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE CHITIETDONHANG SET SOLUONG = @SOLUONG, GIA = @GIA WHERE MADH = @MADH AND MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", ct.MADH);
                cmd.Parameters.AddWithValue("@MASP", ct.MASP);
                cmd.Parameters.AddWithValue("@SOLUONG", ct.SOLUONG);
                cmd.Parameters.AddWithValue("@GIA", ct.GIA);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa chi tiết đơn hàng
        public bool XoaChiTietDonHang(int maDH, int maSP)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM CHITIETDONHANG WHERE MADH = @MADH AND MASP = @MASP";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MADH", maDH);
                cmd.Parameters.AddWithValue("@MASP", maSP);

                return cmd.ExecuteNonQuery() > 0;
            }
        }



    }
}