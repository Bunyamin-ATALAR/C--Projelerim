using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutarı = 0;
        

        private void button1_Click(object sender, EventArgs e)
        {

            int misir, cay, su, bilet,toplam;
            misir = Convert.ToInt16(textBox1.Text);
            cay=Convert.ToInt16(textBox2.Text);
            su=Convert.ToInt16(textBox3.Text);
            bilet=Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;

            kasatutarı = kasatutarı + toplam;

            label11.Text = kasatutarı.ToString() + " TL";
            label12.Text = kasatutarı.ToString()+" TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();


            kasatutarı = kasatutarı * 0;
            label11.Text = kasatutarı.ToString() + " TL";
            label12.Text = kasatutarı.ToString() + " TL";


        }
    }
}
