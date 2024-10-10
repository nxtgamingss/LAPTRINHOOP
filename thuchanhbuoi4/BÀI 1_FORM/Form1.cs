using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BÀI_1_FORM
{
    public partial class Form1 : Form
    {
        Sophuc s1, s2, s3;
        int songuyen;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtThuc.Text);
            int b = int.Parse(txtAo.Text);
            if (rdSP1.Checked == true)
            {
                s1 = new Sophuc(a, b);
                txtSP1.Text = s1.show();
            }
            else if (rdSP2.Checked == true)
            {
                s2 = new Sophuc(a, b);
                txtSP2.Text = s2.show();
            }
            else if (rdSP3.Checked == true)
            {
                s3 = new Sophuc(a, b);
                txtSP3.Text = s3.show();
            }
            else if (rdSonguyen.Checked == true)
            {
                songuyen = int.Parse(txtSonguyen.Text);
                Console.WriteLine(txtSonguyen.Text);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Cong(s2);
            txtKQ.Text = kq.show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Cong(s2, s3);
            txtKQ.Text = kq.show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            int a = int.Parse(txtSonguyen.Text);
            kq = s1.Tru(a);
            txtKQ.Text = kq.show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            int a = int.Parse(txtSonguyen.Text);
            kq = s1.Cong(a);
            txtKQ.Text = kq.show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sophuc kq = new Sophuc();
            kq = s1.Tru(s2,s3);
            txtKQ.Text = kq.show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = new Sophuc();
            s2 = new Sophuc(0,0);
            s3 = new Sophuc(0,0);
            
            txtSP1.Text = s1.show();
            txtSP2.Text = s2.show();
            txtSP3.Text = s3.show();
            

        }

    }
}
