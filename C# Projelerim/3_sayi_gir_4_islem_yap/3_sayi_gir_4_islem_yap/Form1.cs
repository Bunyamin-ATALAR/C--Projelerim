using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_sayi_gir_4_islem_yap
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
            /* Klavyeden girilen üç sayıyı toplayıp sonucu ekrana yazdıran uygulamayı yapınız. */

            int s1, s2, s3, toplama,fark,carpim,bolum;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            toplama = s1 + s2 + s3;
            fark = s1 - s2 - s3;
            carpim = s1 * s2 * s3;
            bolum = s1 / s2 / s3;

            MessageBox.Show("Toplama: " + toplama + "\n" + "Çıkarma: " + fark + "\n" + "Çarpım: " + carpim + "\n" + "Bölüm: " + bolum);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
