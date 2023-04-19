using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav_Ortalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, quiz, toplam;
            double svize, squiz, sfinal; //sınavların ortalamasını hesaplayabilmek için double degerler oluşturdum.


            vize = Convert.ToInt16(textBox1.Text);
            final=Convert.ToInt16(textBox2.Text);
            quiz = Convert.ToInt16(textBox3.Text);
            //burda textbox'lar string ve değişkenler int olduğu için convert(dönüştürmek) yöntemiyle stringleri int'e dönüştürüp birleştirdim.


            svize = vize * 0.40;
            sfinal = final * 0.40;
            squiz = quiz * 0.20;
            //notların ortalamasını hesaplayabilmek double değerlerle hangi sınavın % kaç etkileyeceğini belirtip ortalamayı hesapladım.


         //burda toplam int ama değerler double olduğu için convert(dönüştürmek) yoluyla program değerleri integer'a dönüştürmemi istedi ve dönüştürdüm.
            toplam = Convert.ToInt16(svize + sfinal + squiz);
            //toplam = Convert.ToInt16(svize) + Convert.ToInt16(sfinal) + Convert.ToInt16(squiz); bu şekilde de yapabilirsin!..
            listBox1.Items.Add(toplam.ToString());
        }
    }
}
