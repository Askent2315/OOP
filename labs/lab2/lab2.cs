using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace lab2
{
    public partial class lab2 : Form
    {
        public lab2()
        {
            InitializeComponent();
            this.comboBox1.Items.AddRange(new object[] 
            {
                "Задание 1",
                "Задание 2",
                "Задание 3",
                "Задание 4"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    task1 obj1 = new task1();
                    obj1.Show();
                break;
                case 1:
                    task2 obj2 = new task2();
                    obj2.Show();
                break;
                case 2:
                    task3 obj3 = new task3();
                    obj3.Show();
                break;
                case 3:
                    task4 obj4 = new task4();
                    obj4.Show();
                break;
                default:
                    MessageBox.Show("Вы не выбрали задание");
                break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
