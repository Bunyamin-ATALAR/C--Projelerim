using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komisyon_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bir satıcı sattığı mallardan belirli oranda komisyon almaktadır.
            //200TL’ye kadar olan satışlardan  %3, daha fazla olanlardan ise %2 komisyon
            //almaktadır.
            //Buna göre klavyeden girilen 3 satıştan satıcının alacağı komisyonları ve
            //toplam komisyonu ekrana yazan C# programını yazınız.

            int s1, s2, s3;
            double a,b,c,d,z,f;

            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

//****************************************************************************************
            if (s1<=200)
            {
                a = s1 * 0.03+s1;
                label4.Text = a.ToString() + " TL";
            }

            if (s2<=200)
            {
                b = s2 * 0.03 + s2;
                label5.Text = b.ToString() + " TL";
            }

            if (s3<=200)
            {
                c = s3 * 0.03 + s3;
                label6.Text = c.ToString() + " TL";
            }

            //****************************************************************************************

            if (s1>200) 
            {
                d = s1 * 0.02 + s1;
                label4.Text = d.ToString() + " TL";
            }

            if (s2>200) 
            {
                z = s2 * 0.02 + s2;
                label5.Text = z.ToString() + " TL";
            }

            if (s3>200) 
            {
                f = s3 * 0.02 + s3;
                label6.Text = f.ToString() + " TL";
            }
        }
    }
}
