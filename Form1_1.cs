using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NET_LAB_2_BITS_241_Zaritskaya
{
    public partial class Form1_1 : Form
    {
        public Form1_1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Попытка считать числа из TextBox
            if (double.TryParse(textBox1.Text, out double x) &&
                double.TryParse(textBox2.Text, out double y) &&
                double.TryParse(textBox3.Text, out double z))
            {
                // Вычисляем a и b
                double a = (2 + x) * ((1 + y / (x * x + 3)) / (y * y + 1.0 / (z * z + 4)));
                double b = Math.Pow(1 + Math.Pow(Math.Tan(x / 2), 2), 2);

                // Выводим результат в Label или TextBox
                label_result.Text = $"Результат вычислений:\n\na = {a:F5}, b = {b:F5}";
            }
            else
            {
                MessageBox.Show("Введите корректные числа во все поля!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form1_1_Load(object sender, EventArgs e)
        {

        }
    }
}
