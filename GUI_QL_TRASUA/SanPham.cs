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
    public partial class SanPham : Form
    {
        public SanPham(string username1, string quyen1) 
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
            dataGridView_SanPham.DataSource = bll.GetAllSanPham();
            lbl_username.Text = username;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            SanPham sp = this;
            sp.Hide();
            Home home = new Home(username, quyen);
            home.ShowDialog();
            sp.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            SANPHAMDTO sp = new SANPHAMDTO
            {
                TENSP = txt_tensp.Text,
                GIA = Convert.ToDecimal(txt_gia.Text),
                KICHTHUOC = cbo_kichthuoc.SelectedItem.ToString(),
                TOPPING = txt_topping.Text
            };
            bool isSuccess = bll.ThemSanPham(sp);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadSanPham();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            int maSP = Convert.ToInt32(txt_masp.Text);
            bool isSuccess = bll.XoaSanPham(maSP);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadSanPham();

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            BLL bll = new BLL();
            SANPHAMDTO sp = new SANPHAMDTO
            {
                MASP = Convert.ToInt32(txt_masp.Text),
                TENSP = txt_tensp.Text,
                GIA = Convert.ToDecimal(txt_gia.Text),
                KICHTHUOC = cbo_kichthuoc.SelectedItem.ToString(),
                TOPPING = txt_topping.Text
            };
            bool isSuccess = bll.SuaSanPham(sp);
            if (isSuccess)
            {
                MessageBox.Show("Thành công");
                LoadSanPham();

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
