using labs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class task4 : Form
    {
        public task4()
        {
            InitializeComponent();
        }

        private void task4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int N = 0;
                N = Convert.ToInt32(textBox1.Text);
                int[] A = new int[N];
                for (int i = 0; i < N; i++)
                {
                    A[i] = rnd.Next(100);
                    Console.Write($" {A[i]}");
                }
                int imax = LibClass.task4(A);
                //Создание текстового поля
                string message = "";
                for (int i = 0; i < N; i++)
                {
                    message = message + A[i].ToString();
                    if ((i % 10 == 0) && (i != 0))
                    {
                        message = message + "\n";
                    }
                    else
                    {
                        message = message + " ";
                    }
                }

                label3_Click(message, e);
                message = "";
                for (int i = 0; i < N; i++)
                {
                    if (i == imax)
                    {
                        message = message + ">>" + A[i].ToString() + "<<";
                        textBox2.Text = A[i].ToString();
                    }
                    message = message + A[i].ToString();
                    if ((i % 10 == 0) && (i != 0))
                    {
                        message = message + "\n";
                    }
                    else
                    {
                        message = message + " ";
                    }
                }
                label2_Click(message, e);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = sender.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = sender.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
