using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void click(object sender, MouseEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }
    }
}
