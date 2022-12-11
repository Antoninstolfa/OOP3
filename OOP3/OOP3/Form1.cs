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
            Auto auto = new Auto(textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
        }
    }
}
