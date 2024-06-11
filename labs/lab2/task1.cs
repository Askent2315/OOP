using labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = 0;
                double a = 0, b = 0, q = 0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox3.Text);
                q = Convert.ToDouble(textBox2.Text);
                if (q == 6)
                {
                    textBox4.Text = "Деление на 0!";
                }
                else
                {
                    R = LibClass.task1(a, b, q);
                    textBox4.Text = Convert.ToString(R);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
