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
    public partial class Form1_2 : Form
    {
        public Form1_2()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1_2_1 form1_2_1 = new Form1_2_1())
            {
                DialogResult result = form1_2_1.ShowDialog();
                if (result == DialogResult.OK)
                    Show();
                else
                    Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1_2_2 form1_2_2 = new Form1_2_2())
            {
                DialogResult result = form1_2_2.ShowDialog();
                if (result == DialogResult.OK)
                    Show();
                else
                    Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form1_2_3 form1_2_3 = new Form1_2_3())
            {
                DialogResult result = form1_2_3.ShowDialog();
                if (result == DialogResult.OK)
                    Show();
                else
                    Close();
            }
        }
    }
}
