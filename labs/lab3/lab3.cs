using labs;
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

namespace lab3
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
            this.comboBox1.Items.AddRange(new object[] 
            {
                "Задание 1",
                "Задание 2",
                "Задание 3"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    task5 obj1 = new task5();
                    obj1.Show();
                break;
                case 1:
                    task6 obj2 = new task6();
                    obj2.Show();
                break;
                case 2:
                    task7 obj3 = new task7();
                    obj3.Show();
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
