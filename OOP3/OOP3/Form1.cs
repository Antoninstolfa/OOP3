using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto;

        private void button1_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            auto.Rozjed();
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auto.VratUjeteKm();
            auto.CelkovaSpotreba();
            auto.Zastav(Convert.ToInt32(numericUpDown2.Value));
            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vypis.Text = auto.ToString();
        }
    }
}
