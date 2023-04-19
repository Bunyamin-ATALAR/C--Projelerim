using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikinci_Derece_Denklem_Kok_Bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
İkinci derece denklemin (ax2+bx+c=0)  a, b ve c katsayılarını kullanarak deltayı bulup 
kök var yada yok şeklinde ekrana yazdıralım.Bildiğiniz gibi delta=b2-4ac, delta>=0 ise 
kök vardır, değilse yoktur. 
             */

            int a, b, c, delta;
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            c = Convert.ToInt16(textBox3.Text);

            delta = b * b - 4 * a * c;

            if (delta>=0)   
            {
                label5.Text = delta.ToString()+" Kök Vardır!..";
            }

            else
            {
                label5.Text = delta.ToString()+" Kök Yoktur!..";
            }
        }
    }
}
