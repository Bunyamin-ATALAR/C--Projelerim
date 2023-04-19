using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ögrenci_Adsoyad_Sinav_Bilgisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int sayi1, sayi2, sayi3;
            double ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            sayi1 = Convert.ToInt16(textBox3.Text);
            sayi2= Convert.ToInt16(textBox4.Text);
            sayi3= Convert.ToInt16(textBox5.Text);

            ortalama = (sayi1 * 0.40 + sayi2 * 0.40 + sayi3 * 0.20);

            listBox1.Items.Add("Adı: "+ad+"   "+"Soyadı: "+soyad+"   "+"Ortalaması: "+ortalama);
        }
    }
}
