using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace библиотека
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.выдача". При необходимости она может быть перемещена или удалена.
            this.выдачаTableAdapter.Fill(this.dataSet1.выдача);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.выдачаTableAdapter.Fill(this.dataSet1.выдача);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
