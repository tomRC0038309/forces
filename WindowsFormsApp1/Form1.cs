using System;
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.00));
        }

        double asin(double x)
        private void Button1_Click(object sender, EventArgs e)
        {
            double force = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox2.Text);


            double Fx = force * cos(angle);
            double Fy = force * sin(angle);

            label1.Text = "Fx = " + Fx;
            Label2.Text = "Fy = " + Fy;
            

        }
    }
}
