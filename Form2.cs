using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NET_LAB_2_BITS_241_Zaritskaya
{
    struct Zavod
    {
        public string name;
        public string location;
        public double workers;
        public string productionType;
        public string DisplayInfo()
        {
            return $"--- Информация о заводе ---\n" +
                               $"Название: {name}\n" +
                               $"Местоположение: {location}\n" +
                               $"Количество работников: {workers}\n" +
                               $"Тип продукции: {productionType}";
        }
    }
    public partial class Form2 : Form
    {
        public Form2()
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
            if (double.TryParse(textBox3.Text, out double workers))
            {
                if (workers < 0)
                {
                    textBox_TextInvalid(textBox3, e);
                    MessageBox.Show("Введите корректное число работников!", "Ошибка ввода",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Zavod zavod;
                zavod.name = textBox1.Text;
                zavod.location = textBox2.Text;
                zavod.workers = workers;
                zavod.productionType = textBox4.Text;
                label_result.Text = zavod.DisplayInfo();
            }
            else
            {
                textBox_TextInvalid(textBox3, e);
                MessageBox.Show("Введите корректные значения в полях!", "Ошибка ввода",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox_Check(textBox3, e);
        }
    }
}
