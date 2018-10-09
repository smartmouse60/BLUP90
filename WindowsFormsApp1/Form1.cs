using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Json files(*.json)|*.json|All files(*.*)|*.*";
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

        private void запускИнтеграцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form5 f5 = new Form5();
            f1.Hide();
            f5.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            обменДаннымиToolStripMenuItem.Enabled = true;
            базаДанныхToolStripMenuItem.Enabled = true;
            формыToolStripMenuItem.Enabled = true;
            интеграцияСBLUPToolStripMenuItem.Enabled = true;
            оПрограммеToolStripMenuItem.Enabled = true;
            сохранитьToolStripMenuItem.Enabled = true;

            var mydate = DateTime.Now;
            //DateTime date1 = new DateTime;
            string date = mydate.ToString("H-mm-ss dd-MM-yyyy");
            string path = date+"_open.json";
            string text = "";

            System.IO.File.WriteAllText("file\\"+path,"");
<<<<<<< HEAD
=======

         
          

        }
        static class GlobalVars
        {
            public static string filename;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            GlobalVars.filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(GlobalVars.filename);
           if (fileText != null)
            {
                обменДаннымиToolStripMenuItem.Enabled = true;
                базаДанныхToolStripMenuItem.Enabled = true;
                формыToolStripMenuItem.Enabled = true;
                интеграцияСBLUPToolStripMenuItem.Enabled = true;
                оПрограммеToolStripMenuItem.Enabled = true;
                сохранитьToolStripMenuItem.Enabled = true;
            }
        }
>>>>>>> parent of 809cbbd... слияние веток

         
          

        }
        static class GlobalVars
        {
            public static string filename;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            GlobalVars.filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(GlobalVars.filename);
           if (fileText != null)
            {
                обменДаннымиToolStripMenuItem.Enabled = true;
                базаДанныхToolStripMenuItem.Enabled = true;
                формыToolStripMenuItem.Enabled = true;
                интеграцияСBLUPToolStripMenuItem.Enabled = true;
                оПрограммеToolStripMenuItem.Enabled = true;
                сохранитьToolStripMenuItem.Enabled = true;
            }
        }

        private void проверкаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            FormBlup1 form_blup1 = new FormBlup1();
            f1.Hide();
            form_blup1.Show();
        }
    }
}
