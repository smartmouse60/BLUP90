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
    public partial class FormBlup1 : Form
    {
        public FormBlup1()
        {
            InitializeComponent();
        }

        private void FormBlup1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "blupDataSet.cowmilk". При необходимости она может быть перемещена или удалена.
            this.cowmilkTableAdapter.Fill(this.blupDataSet.cowmilk);

        }
    }
}
