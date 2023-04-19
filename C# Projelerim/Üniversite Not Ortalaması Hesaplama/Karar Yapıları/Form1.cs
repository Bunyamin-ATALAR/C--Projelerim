using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapıları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3;
            string durum;
            double ortalama;

            s1 = Convert.ToInt16(textBox1.Text);
            s2= Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            ortalama = s1 * 0.40 + s2 * 0.40 + s3 * 0.20;

            if (ortalama>=50)
            {
                textBox4.Text = ortalama.ToString("0.00")+"  /  Geçti";
            }

            else
            {
                textBox4.Text = ortalama.ToString("0.00")+"  /  Kaldı";
            }

            


        }
    }
}
