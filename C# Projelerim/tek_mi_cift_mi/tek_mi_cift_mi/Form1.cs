using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tek_mi_cift_mi
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
             Klavyeden bir sayı girilerek girilen sayının  Tek mi?, Çift mi?
             Olduğunu kontrol ederek sonucu ekrana aşağıdaki gibi yazdırınız.
             Girdiğiniz sayı ………, (TEK veya ÇİFT) 
             */

            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);

            if (sayi%2==0)
            {
                label2.Text = "Çift";
            }
            else
            {
                label2.Text = "Tek";
            }
        }
    }
}
