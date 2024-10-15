using DOAN_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace GUI_QL_TRASUA
{
    public partial class Home : Form
    {
        public Home(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            LoadSanPham();

        }


        string username;
        string quyen;

        private void LoadSanPham()
        {

            BLL bll = new BLL();
            lbl_soluongkh.Text = bll.GetSoKhachHang().ToString();
            lbl_soluongsp.Text = bll.GetSoSanPham().ToString();
            lbl_soluongdh.Text = bll.GetSoDonHang().ToString();
            cbo_ngay.DataSource = bll.GetAllNgayThangNam();
            cbo_ngay.DisplayMember = "NgayThangNam";
            cbo_ngay.ValueMember = "NgayThangNam";
            cbo_thang.DataSource = bll.GetAllThangNam();
            cbo_thang.DisplayMember = "ThangNam";
            cbo_thang.ValueMember = "ThangNam";

            cbo_nam.DataSource = bll.GetAllNam();
            cbo_nam.DisplayMember = "Nam";
            cbo_nam.ValueMember = "Nam";
            dataGridView_NV_QUYEN.DataSource = bll.GetAllNV_TEN_QUYEN();

            lbl_username.Text = username;
            lbl_quyen.Text = quyen;

            btn_chitietdh.Visible = true;
            btn_donhang.Visible = true;
            btn_khach.Visible = true;
            btn_nhanvien.Visible = false;
            btn_sanpham.Visible = false;


            if (quyen == "Admin")
            {
                btn_chitietdh.Visible = true;
                btn_donhang.Visible = true;
                btn_khach.Visible = true;
                btn_nhanvien.Visible = true;
                btn_sanpham.Visible = true;
            }
            //lbl_username1.Text = username;

            //lbl_tongdt_nam.Text = bll.TongDoanhThuTheoNam().ToString();
        }

        private void btn_tongdoanthu_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                BLL bll = new BLL();

                string ngay = cbo_ngay.SelectedValue.ToString();
                int thang = int.Parse(cbo_thang.SelectedValue.ToString());
                int nam = int.Parse(cbo_nam.SelectedValue.ToString());

                lbl_tongdt_ngay.Text = bll.TongDoanhThuTheoNgay(ngay).ToString();
                lbl_tongdt_thang.Text = bll.TongDoanhThuTheoThang(thang).ToString();
                lbl_tongdt_nam.Text = bll.TongDoanhThuTheoNam(nam).ToString();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng", "Thông báo");
            }
            
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            SanPham sp = new SanPham(username, quyen);
            sp.ShowDialog();
            home.Close();
        }

        private void btn_donhang_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            DonHang dh = new DonHang(username, quyen);
            dh.ShowDialog();
            home.Close();
        }

        private void btn_chitietdh_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            ChiTietDonHang ct = new ChiTietDonHang(username, quyen);
            ct.ShowDialog();
            home.Close();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            NhanVien nv = new NhanVien(username, quyen);
            nv.ShowDialog();
            home.Close();
        }

        private void btn_khach_Click(object sender, EventArgs e)
        {
            Home home = this;
            home.Hide();
            KhachHang khach = new KhachHang(username, quyen);
            khach.ShowDialog();
            home.Close();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng form ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
