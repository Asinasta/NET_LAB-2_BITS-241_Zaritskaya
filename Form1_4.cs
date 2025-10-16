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
    public partial class Form1_4 : Form
    {
        public Form1_4()
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
            if (double.TryParse(box.Text, out double value))
            {
                if (value < 0 || value > 9) // диапазон 0–9
                {
                    box.BackColor = Color.Red;
                }
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
                    if (value >= 0 && value <= 9) // диапазон 0–9
                    {
                        box.BackColor = SystemColors.Window; // число
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double digit))
            {
                switch (digit)
                {
                    case 0: label_result.Text = "ноль"; break;
                    case 1: label_result.Text = "один"; break;
                    case 2: label_result.Text = "два"; break;
                    case 3: label_result.Text = "три"; break;
                    case 4: label_result.Text = "четыре"; break;
                    case 5: label_result.Text = "пять"; break;
                    case 6: label_result.Text = "шесть"; break;
                    case 7: label_result.Text = "семь"; break;
                    case 8: label_result.Text = "восемь"; break;
                    case 9: label_result.Text = "девять"; break;
                    default: 
                        textBox_TextInvalid(textBox1, e); 
                        label_result.Text = "Неверный ввод.\nВведите цифру от 0 до 9."; 
                        break;
                }

            }
            else
            {
                textBox_TextInvalid(textBox1, e);
                MessageBox.Show("Введите корректное значение в поле!", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox1, e);
        }
    }
}
