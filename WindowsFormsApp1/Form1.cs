﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        
        double asin(double x)
        {
            return (Math.Asin(x) * 180 * Math.PI);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
