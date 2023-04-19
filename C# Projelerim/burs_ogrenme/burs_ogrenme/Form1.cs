using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burs_ogrenme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, a1, a2, a3, a4;
            s1 = Convert.ToInt16(textBox1.Text);
            a1 = 100; 
            a2 = 120; 
            a3 = 150; 
            a4 = 200;

            if (s1==1)
            {
                label2.Text = a1.ToString()+" TL";
            }

            if (s1 == 2)
            {
                label2.Text = a2.ToString() + " TL";
            }

            if (s1 == 3)
            {
                label2.Text = a3.ToString() + " TL";
            }

            if (s1 == 4)
            {
                label2.Text = a4.ToString() + " TL";
            }
        }
    }
}
