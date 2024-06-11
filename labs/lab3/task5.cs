using labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }
        int index = 0;
        double[,] history = new double[100, 2];
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
                double a = 0, b = 0;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                history[index, 0] = a;
                history[index, 1] = b;
                index++;
                R = MyCalc1.task5(a, b);
                textBox3.Text = R;
                this.comboBox1.Items.AddRange(new object[]
                {
                    R
                });
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
            textBox3.Text = this.comboBox1.Text;
        }
    }
}
