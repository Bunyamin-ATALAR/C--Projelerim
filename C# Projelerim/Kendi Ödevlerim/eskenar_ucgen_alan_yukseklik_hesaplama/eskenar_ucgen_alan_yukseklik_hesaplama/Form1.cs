using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eskenar_ucgen_alan_yukseklik_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a, b, c;
            a = Convert.ToDouble(textBox1.Text);

            b = (3 / 4) * a * a;
            c = 3 * (a / 2);

            label4.Text = b.ToString();
            label5.Text = c.ToString();


        }
    }
}
