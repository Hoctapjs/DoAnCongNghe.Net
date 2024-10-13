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


    }
}