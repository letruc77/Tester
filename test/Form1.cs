using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //truc them

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Year == 2019)
            {
                double txtKetQua = 0;
                double a = 1;
                double b = 2;
                double c = a - b;
                txtKetQua = c;
            }
        }
    }
}
