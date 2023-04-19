using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplam_Tutar_Indirimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Klavyeden girilen toplam tutar değeri 100’den küçük ise
             %5, 100 ile 500 arasında ise %10, 500’den büyük ise %15 
            indirim yapıp ödenecek tutarı hesaplayıp ekrana yazdıran uygulamayı yapınız.
             */

            double toplamtutar = Convert.ToDouble(textBox1.Text);

            if (toplamtutar<100 && toplamtutar>=0)
            {
                toplamtutar = toplamtutar * 0.95;
                label3.Text = toplamtutar.ToString() + " TL" + " %5 İndirimli Hali";
            }

            if (toplamtutar>=100 && toplamtutar<=500)
            {
                toplamtutar = toplamtutar * 0.90;
                label3.Text=toplamtutar.ToString()+ " TL" + " %10 İndirimli Hali";
            }

            if (toplamtutar>500)
            {
                toplamtutar = toplamtutar * 0.85;
                label3.Text=toplamtutar.ToString()+" TL"+" %15 İndirimli Hali";
            }

            
        }
    }
}
