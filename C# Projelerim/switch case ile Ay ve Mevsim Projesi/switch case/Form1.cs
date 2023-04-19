using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ay = Convert.ToInt16(textBox1.Text);

            switch (ay)
            {
                case 1:label3.Text = "Ocak";
                    break;

                case 2:label3.Text = "Şubat";
                    break;

                case 3:
                    label3.Text = "Mart";
                    break;

                case 4:
                    label3.Text = "Nisan";
                    break;

                case 5:
                    label3.Text = "Mayıs";
                    break;

                case 6:
                    label3.Text = "Haziran";
                    break;

                case 7:
                    label3.Text = "Temmuz";
                    break;

                case 8:
                    label3.Text = "Ağustos";
                    break;

                case 9:
                    label3.Text = "Eylül";
                    break;

                case 10:
                    label3.Text = "Ekim";
                    break;

                case 11:
                    label3.Text = "Kasım";
                    break;

                case 12:
                    label3.Text = "Aralık";
                    break;

                default:label3.Text = "Hatalı Ay Girdiniz!..";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mevsim = textBox2.Text;
            switch (mevsim)
            {                        
                case "Kış": label4.Text = "Aralık - Ocak - Şubat";
                    break;

                case "Yaz": label4.Text = "Haziran - Temmuz - Ağustos";
                    break;

                case "İlkbahar": label4.Text = "Mart - Nisan - Mayıs";
                    break;

                case "Sonbahar": label4.Text = "Eylül - Ekim - Kasım";
                    break;
                default: label4.Text = "Yanlış Mevsim Girdiniz!..";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
