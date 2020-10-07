using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void x4_Click(object sender, EventArgs e)
        {
            string a, b, c,d,a1;
            
           
            
                a = x1.Text;
                b = x2.Text;
            d = x5.Text;
            a1 = x6.Text;


            c = "mã sinh viên:" + a + "họ và tên:" + b + "lớp:" + d + "địa chỉ:" + a1;
            
            
           
            x3.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

      
    }
}
