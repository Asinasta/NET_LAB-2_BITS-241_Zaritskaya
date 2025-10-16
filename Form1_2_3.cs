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
    public partial class Form1_2_3 : Form
    {
        public Form1_2_3()
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
            if (double.TryParse(box.Text, out double value))
            {
                box.BackColor = value <= 0 ? Color.Red : SystemColors.Window;
            }
            else
            {
                box.BackColor = Color.Red;
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
                    if (value > 0) { box.BackColor = SystemColors.Window; } // число больше нуля
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double a3) &&
                double.TryParse(textBox2.Text, out double b3) &&
                double.TryParse(textBox3.Text, out double alphaDeg))
            {
                if (a3 <= 0 || b3 <= 0 || alphaDeg <= 0 || alphaDeg >= 180)
                {
                    textBox_TextInvalid(textBox1, e);
                    textBox_TextInvalid(textBox2, e);
                    textBox_TextInvalid(textBox3, e);
                    MessageBox.Show("Стороны должны быть положительными, а угол — от 1 до 179°.", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                double alphaRad = alphaDeg * Math.PI / 180.0; // из градусов в радианы
                double S = 0.5 * a3 * b3 * Math.Sin(alphaRad);

                if (S <= 0 || double.IsNaN(S))
                {
                    MessageBox.Show("Такого треугольника не существует.", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                label_result.Text = $"Площадь треугольника: {S:F2}";
            }
            else
            {
                MessageBox.Show("Введите корректные числа во все поля!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox1, e);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox2, e);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox3, e);
        }
    }
}
