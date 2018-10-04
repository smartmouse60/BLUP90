using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void экспортВФРБToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f3 = new Form3();
            f1.Hide();
            f3.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            f1.Hide();
            f2.Show();
        }

        private void импортВФБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form4 f4 = new Form4();
            f1.Hide();
            f4.Show();
        }
    }
}
