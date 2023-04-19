using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Fiyatı_KDV_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunad;
            int fiyat;
            double kdv8, kdv18;

            urunad = "Iphone 6S";
            fiyat = 4999;

            kdv8 = fiyat * 0.08;
            kdv18 = fiyat * 0.16;

            listBox1.Items.Add("Ürün Adı: " + urunad + "   " + "Ürün Fiyatı: " + fiyat + "   " + "%8 KDV'si: " + kdv8 + "   " + "%18 KDV'si: " + kdv18);
        }
    }
}
