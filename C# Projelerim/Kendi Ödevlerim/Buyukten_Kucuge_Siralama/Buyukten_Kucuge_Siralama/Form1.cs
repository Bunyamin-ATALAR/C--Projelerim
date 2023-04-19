using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buyukten_Kucuge_Siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int s1, s2, s3;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            s3 = Convert.ToInt16(textBox3.Text);

            if (s1 > s2 && s2 > s3)
            {
                label4.Text = s1.ToString()+">" + s2.ToString()+">" + s3.ToString();
            }

            if (s1 > s3 && s3 > s2)
            {
                label4.Text = s1.ToString() + ">" + s3.ToString() + ">" + s2.ToString();
            }

            if (s2 > s1 && s1 > s3)
            {
                label4.Text = s2.ToString() + ">" + s1.ToString() + ">" + s3.ToString();
            }

            if (s2 > s3 && s3 > s1)
            {
                label4.Text = s2.ToString() + ">" + s3.ToString() + ">" + s1.ToString();
            }

            if (s3 > s1 && s1 > s2)
            {
                label4.Text = s3.ToString() + ">" + s1.ToString() + ">" + s2.ToString();
            }

            if (s3 > s2 && s2 > s1)
            {
                label4.Text = s3.ToString() + ">" + s2.ToString() + ">" + s1.ToString();
            }
        }
    }
}
