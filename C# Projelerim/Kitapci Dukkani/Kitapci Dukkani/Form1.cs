using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapci_Dukkani
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
             kitap adeti 8 TL'dir.

             0-20 adet arası %20 indirim.
             21-40 adet arası %40 indirim.
             41 ve üzeri ise %50 indirim.
             */
            int adet;
            double toplam;

            adet = Convert.ToInt16(textBox1.Text);

            if (adet>=0 && adet<=20)  
            {
                toplam = adet * 8 * 0.80;
                label3.Text = toplam + " TL";
            }
            if (adet>=21 && adet<=40) 
            {
                toplam = adet * 8 * 0.60;
                label3.Text = toplam + " TL";
            }
            if (adet >= 41)
            {
                toplam = adet * 8 * 0.50;
                label3.Text = toplam + " TL";
            }
        }
    }
}
