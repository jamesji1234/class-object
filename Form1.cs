﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_object
{
    public partial class Form1 : Form
    {
        Calculator Squarel = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeW_Click(object sender, EventArgs e)
        {
            Squarel.Row = double.Parse(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Squarel.Colum = double.Parse(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wide : " + Squarel.Row + "..");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("High : " + Squarel.Colum + "..");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Squarel.getArea();
            MessageBox.Show("Sum = " + Squarel.getArea());
        }
    }
}
