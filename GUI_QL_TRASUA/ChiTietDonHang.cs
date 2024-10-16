using DOAN_BLL;
using DOAN_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class ChiTietDonHang : Form
    {
        public ChiTietDonHang(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
            LoadChiTietDonHang();
        }

        string username;
        string quyen;

        private void LoadChiTietDonHang()
        {
            BLL bll = new BLL();
            dataGridView_ChiTietDonHang.DataSource = bll.GetAllChiTietDonHang();
            lbl_username.Text = username;
            cbo_madh.DataSource = bll.GetMaDH_From_DONHANG();
            cbo_madh.DisplayMember = "MADH";
            cbo_madh.ValueMember = "MADH";
            cbo_masp.DataSource = bll.GetMaSP_From_SANPHAM();
            cbo_masp.DisplayMember = "TENSP";
            cbo_masp.ValueMember = "MASP";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            ChiTietDonHang ct = this;
            ct.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            ct.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            if (string.IsNullOrEmpty(txt_gia.Text))
            {
                CHITIETDONHANGDTO ct = new CHITIETDONHANGDTO
                {
                    MADH = Convert.ToInt32(cbo_madh.SelectedValue.ToString()),
                    MASP = Convert.ToInt32(cbo_masp.SelectedValue.ToString()),
                    SOLUONG = Convert.ToInt32(txt_soluong.Text),
                    GIA = 0
                };
                bool isSuccess = bll.ThemChiTietDonHang(ct);
                if (isSuccess)
                {
                    MessageBox.Show("Thành công");
                    LoadChiTietDonHang();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            int maDH = Convert.ToInt32(cbo_madh.SelectedValue.ToString());
            int maSP = Convert.ToInt32(cbo_masp.SelectedValue.ToString());
            bool isSuccess = bll.XoaChiTietDonHang(maDH, maSP);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();

            CHITIETDONHANGDTO ct = new CHITIETDONHANGDTO
            {
                MADH = Convert.ToInt32(cbo_madh.SelectedValue.ToString()),
                MASP = Convert.ToInt32(cbo_masp.SelectedValue.ToString()),
                SOLUONG = Convert.ToInt32(txt_soluong.Text),
                GIA = 0
            };
            bool isSuccess = bll.SuaChiTietDonHang(ct);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadChiTietDonHang();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
