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
    public partial class Form1_3 : Form
    {
        public Form1_3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Попытка считать числа из TextBox
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b) &&
                double.TryParse(textBox3.Text, out double c))
            {
                // Вычисляем a и b
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    label_result.Text = $"Два корня: x1 = {x1}, x2 = {x2}";
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    label_result.Text = $"Один корень: x = {x}";
                }
                else
                {
                    label_result.Text = "Нет действительных корней";
                }

            }
            else
            {
                MessageBox.Show("Введите корректные числа во все поля!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_c_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
