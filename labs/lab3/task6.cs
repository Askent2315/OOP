using labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }
        int index = 0;
        double[,] history = new double[100, 3];
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string R = "";
                double a = 0, b = 0, d = 0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                d = Convert.ToDouble(textBox4.Text);
                history[index, 0] = a;
                history[index, 1] = b;
                history[index, 2] = d;
                index++;
                R = MyCalc2.task6(a, b, d);
                textBox3.Text = R;
                this.comboBox1.Items.AddRange(new object[]
                {
                    R
                });
                if (d < a)
                {
                    label5.Text = "(a+b)/d + (a-b)/a";
                }
                else
                {
                    label5.Text = "(a-b)/d";
                }
            }
            catch
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(history[this.comboBox1.SelectedIndex, 0]);
            textBox2.Text = Convert.ToString(history[this.comboBox1.SelectedIndex, 1]);
            textBox4.Text = Convert.ToString(history[this.comboBox1.SelectedIndex, 2]);
            textBox3.Text = this.comboBox1.Text;
            if (history[this.comboBox1.SelectedIndex, 2] < history[this.comboBox1.SelectedIndex, 0])
            {
                label5.Text = "(a+b)/d + (a-b)/a";
            }
            else
            {
                label5.Text = "a*b/d";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
