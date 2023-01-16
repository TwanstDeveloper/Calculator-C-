using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is button Used For close Application
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculation_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            double z = x + y;
            result.Text = z + "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            double z = x - y;
            result.Text = z + "";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            double z = x * y;
            result.Text = z + "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            double z = x / y;
            result.Text = z + "";
        }

        private void btncamcel_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            double z = x + y;
            double m = z * 0;
            result.Text = m + "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
