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
        private void textBox_TextInvalid(object sender, EventArgs e)
        {
            var box = sender as System.Windows.Forms.TextBox;
            if (box == null) { return; }
            if (!double.TryParse(box.Text, out _)) // если не число
            {
                box.BackColor = Color.Red;
            }
            else
            {
                box.BackColor = SystemColors.Window;
            }
        }
        private void textBox_Check(object sender, EventArgs e)
        {
            var box = sender as System.Windows.Forms.TextBox;
            if (box != null)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.BackColor = SystemColors.Window; // пустое поле
                }
                if (double.TryParse(box.Text, out double value))
                {
                    box.BackColor = SystemColors.Window; // число
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a) &&
                double.TryParse(textBox2.Text, out double b) &&
                double.TryParse(textBox3.Text, out double c))
            {
                if (a == 0)
                {
                    textBox1.BackColor = Color.Red;
                    MessageBox.Show("Коэффициент 'a' не может быть равен нулю!","Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }

                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    label_result.Text = $"Два корня: \nx1 = {x1:F3}, \nx2 = {x2:F3}";
                }
                else if (D == 0)
                {
                    double x = -b / (2 * a);
                    label_result.Text = $"Один корень: \nx = {x:F3}";
                }
                else
                {
                    label_result.Text = "Нет действительных корней";
                }
            }
            else
            {
                textBox_TextInvalid(textBox1, e);
                textBox_TextInvalid(textBox2, e);
                textBox_TextInvalid(textBox3, e);
                MessageBox.Show("Введите корректные числа во все поля!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox1, e);
        }
        private void textBox_b_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox2, e);
        }
        private void textBox_c_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox3, e);
        }
    }
}