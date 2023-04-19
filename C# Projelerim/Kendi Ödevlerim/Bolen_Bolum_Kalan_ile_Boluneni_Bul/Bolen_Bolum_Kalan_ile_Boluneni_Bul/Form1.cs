using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolen_Bolum_Kalan_ile_Boluneni_Bul
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
//Bir bölme işleminde bölen, bölüm ve kalan değerleri bilinmektedir.
//Bu değerler kullanılarak bölünen sayıyı bulmaya yarayan uygulamayı yapınız.
//(NOT hiçbir sayı 0 ‘ a bölünemez dolayısı ile kontrol edilmesi gerekmektedir.)

            int s1, s2, s3,formul,a;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            formul = s1 * s2 + s3;

            label5.Text = formul.ToString();

            if (s1 == 0 || s2 == 0) 
            {
                a = 0;
                label5.Text = a.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
