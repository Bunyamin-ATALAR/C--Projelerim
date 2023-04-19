using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negatif_mi_Pozitif_mi
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
            Klavyeden girilen sayının Negatif veya Pozitif olduğunu kontrol ederek 
            durumunu ekrana yazdıran uygulamayı yapınız.
            */

            int sayi = Convert.ToInt16(textBox1.Text);

            if (sayi<0)
            {
                label2.Text = "Negatif";
            }
            else
            {
                label2.Text = "Pozitif";
            }
        }
    }
}
