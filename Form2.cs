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

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double workers))
            {
                if (workers < 0)
                {
                    MessageBox.Show("Введите корректное число работников!", "Ошибка ввода",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Zavod zavod;
                zavod.name = textBox1.Text;
                zavod.location = textBox2.Text;
                zavod.workers = workers;
                zavod.productionType = textBox4.Text;
                MessageBox.Show(zavod.DisplayInfo(), "Результат");
                label_result.Text = zavod.DisplayInfo();
            }
            else
            {
                MessageBox.Show("Введите корректные значения в полях!", "Ошибка ввода",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
