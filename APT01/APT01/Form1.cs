using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            resultado = num1 + num2;

            label4.Text = Convert.ToString(resultado);

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            resultado = num1 - num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            resultado = num1 * num2;

            label4.Text = Convert.ToString(resultado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            resultado = num1 / num2;

            label4.Text = Convert.ToString(resultado);
        }
    }
}
