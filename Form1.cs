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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Task1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1_0 form1_0 = new Form1_0())
            {
                DialogResult result = form1_0.ShowDialog();
                if (result == DialogResult.OK)
                    Show(); // только если пользователь нажал "Назад"
                else
                    Close(); // если крестик, закрываем приложение
            }
        }
        private void Task2_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form2 form2 = new Form2())
            {
                DialogResult result = form2.ShowDialog();
                if (result == DialogResult.OK)
                    Show();
                else
                    Close();
            }
        }
    }
}
