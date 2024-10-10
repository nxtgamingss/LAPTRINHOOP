using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_trang36
{
    public partial class Form1 : Form
    {
        private CTime thoiGian;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thoiGian = new CTime();
            txtThoigian.Text = thoiGian.XuatThoiGian();
        }

        private void butNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGio.Text) || string.IsNullOrEmpty(txtPhut.Text) || string.IsNullOrEmpty(txtGiay.Text)|| string.IsNullOrEmpty(txtGiaynew.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giờ, phút, giây,giây cần thêm ! ","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int gio = int.Parse(txtGio.Text);
            int phut = int.Parse(txtPhut.Text);
            int giay = int.Parse(txtGiay.Text);

            thoiGian.NhapThoiGian(gio, phut, giay);

            int giaynew = int.Parse(txtGiaynew.Text);
            txtThoigian.Text = thoiGian.XuatThoiGian();
        }

        private void butCong_Click(object sender, EventArgs e)
        {
            int giayThem = int.Parse(txtGiaynew.Text);
            thoiGian = thoiGian + giayThem;
            txtKq.Text = thoiGian.XuatThoiGian();
        }

        private void butTru_Click(object sender, EventArgs e)
        {
            int giayThem = int.Parse(txtGiaynew.Text);
            thoiGian = thoiGian - giayThem;
            txtKq.Text = thoiGian.XuatThoiGian();
        }

        private void butCong1_Click(object sender, EventArgs e)
        {
            thoiGian++;
            txtKq.Text = thoiGian.XuatThoiGian();
        }

        private void butTru1_Click(object sender, EventArgs e)
        {
            thoiGian--;
            txtKq.Text = thoiGian.XuatThoiGian();
        }

        private void txtGiaynew_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
