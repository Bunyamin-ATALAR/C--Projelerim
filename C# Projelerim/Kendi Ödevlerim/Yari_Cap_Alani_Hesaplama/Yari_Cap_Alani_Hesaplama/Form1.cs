using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yari_Cap_Alani_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Yarı çapı dışarıdan girilen dairenin alanını hesaplama uygulamayı yapınız. 
            (formül : pi*r*r pi=3.14 sabit olarak tanımlayınız.) (if yok) 
             */

            double sayi, pi,alan;
            sayi = Convert.ToDouble(textBox1.Text);
            pi = 3.14;
            alan = pi * sayi * sayi;

            label2.Text = alan.ToString("0.000");

        }
    }
}
