using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace En_Buyuk_Sayiyi_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Klavyeden girilen 3 sayının içinden en büyüğünü bulan uygulamayı yapınız.

            int s1, s2, s3;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            if (s1>s2 && s1>s3)
            {
                label4.Text = s1.ToString()+"  1.Sayi.";
            }

            if (s2>s1 && s2>s3)
            {
                label4.Text = s2.ToString() + "  2.Sayi.";
            }

            if (s3>s1 && s3>s2)
            {
                label4.Text = s3.ToString() + "  3.Sayi";
            }
            if (s1==s2 && s2==s3)
            {
                label4.Text = "Sayılar birbirine eşit";
            }
        }
    }
}
