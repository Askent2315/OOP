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
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }

        private void task2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double q = 0;
                double x = 0, y = 0, z = 0;
                x = Convert.ToDouble(textBox1.Text);
                y = Convert.ToDouble(textBox3.Text);
                z = Convert.ToDouble(textBox2.Text);
                if (LibClass.Min(x * x + y + z, x * y * z) == 0)
                {
                    textBox4.Text = "Деление на 0!";
                }
                else
                {
                    q = LibClass.task2(x, y, z);
                    textBox4.Text = Convert.ToString(q);
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
