﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_ile_faktoriyel_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            int faktoriyel = 1;

            for (int i = 1; i < sayi; i++)
            {
                faktoriyel *= 2;
                if (faktoriyel==sayi)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
