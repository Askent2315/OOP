using labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void task3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanel1.Controls.Clear();
                double Xn, Xk = 0;
                double[,] Result = new double[10, 3];
                Xn = Convert.ToDouble(textBox1.Text);
                Xk = Convert.ToDouble(textBox2.Text);
                Result = LibClass.task3(Xn, Xk);
                textBox3.Text = "";
                for (int i = 0; i < 10; i++)
                {
                    double x = Math.Round(Result[i, 0], 3);
                    double y = Math.Round(Result[i, 1], 3);
                    double s = Math.Round(Result[i, 2], 3);
                    string str = i+ ")" + "x =" + x +"\t\t"+ "y =" + y + "\t\t" + "s =" + s;
                    textBox3.AppendText(str+ Environment.NewLine);
                    str = "";
                 }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }   


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

    }
}
