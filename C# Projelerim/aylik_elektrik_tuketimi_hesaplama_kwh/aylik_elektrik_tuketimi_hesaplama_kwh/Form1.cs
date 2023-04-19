using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aylik_elektrik_tuketimi_hesaplama_kwh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aylık elektrik faturası hesaplanacaktır.
            //Kullanıcıdan kaç kWh tükettiğini alınız.
            //Eğer tüketim 150’den küçükse kWh’i 10 kuruş,
            //eğer 150 ile 300 arasında ise 20 kuruş,
            //300 üzeri ise 40 kuruş olarak hesaplanmaktadır.
            //Kişinin yaptığı tüketime göre faturasının kaç TL olacağını hesaplayıp
            //ekrana yazdırınız.

            int a = Convert.ToInt16(textBox1.Text);
            double b,c,d;

            if (a<150)
            {
                b = a * 0.10 + a;
                label3.Text = b.ToString()+" TL";
            }

            if (a>=150 && a<300)
            {
                c = a * 0.20 + a;
                label3.Text = c.ToString() + " TL";
            }

            if (a>=300)
            {
                d = a * 0.40 + a;
                label3.Text = d.ToString() + " TL";
            }
        }
    }
}
