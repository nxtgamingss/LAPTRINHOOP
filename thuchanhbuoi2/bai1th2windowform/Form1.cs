using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1th2windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void thucthi_Click(object sender, EventArgs e)
                {
                    Diem diem = new Diem(); 
                    float a= float.Parse(txthoanhdo.Text);
                    float b = float.Parse(txttungdo.Text);
                    float c = float.Parse(txtcaodo.Text);
                     diem.Nhap(a, b, c); ;
                    txtToado.Text = diem.In();
        }
    }
}
