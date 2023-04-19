using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_gecti_kaldi
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
//Bir öğrenciye ait 2 sınav notunun ve 2 performans ortalamasını hesaplayan
//ve ortalama 50’den küçükse ekrana “kaldı” büyükse “geçti” yazan programı yazınız.

            //int s1, s2, s3, s4; böyle yaparsan ortalama virgüllü olmaz,yuvarlanır.
            double ort, s1, s2, s3, s4;

            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);
            s4 = Convert.ToInt16(textBox4.Text);

            ort = (s1 + s2 + s3 + s4) / 4;

            if (ort>=50)
            {
                textBox5.Text = ort.ToString("0.00") +"  Geçtiniz!";
            }

            if (ort<50)
            {
                textBox5.Text = ort.ToString("0.00") + "   Kaldınız!";
            }
        }
    }
}
