﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int v = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (x % 2 == 0)
            {
                button1.BackColor = Color.Green;
                x++;
            }
            else
            {
                button1.BackColor = Color.Yellow;
                x++;
            }
            int z = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            int y = Convert.ToInt32(textBox1.Text);
            if(v == 1)


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            v = 1;
        }
    }
}
