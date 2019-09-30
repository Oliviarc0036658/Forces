using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sin(double x)
        {
            return (Math.Sin(x * Math. PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double force, angle;
          // Names variables
            try
            {

                force = double.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("Not a correct value.");
                force = 0.0;
            }

            try
            {
                angle = double.Parse(textBox1.Text);
               
            }

            catch
            {
                MessageBox.Show("Not a correct value.");
                angle = 0.0;
            }
            // Above checks for any faults in the numbers such as a letter.
            double Fx = force * cos(angle);
            label3.Text = "fx = " + Fx;

            double Fy = force * sin(angle);
            label2.Text = "fy = " + Fy;
        }
    }
}
