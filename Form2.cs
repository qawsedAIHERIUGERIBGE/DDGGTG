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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
// TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.издания". При необходимости она может быть перемещена или удалена.
this.изданияTableAdapter.Fill(this.dataSet1.издания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.разделы". При необходимости она может быть перемещена или удалена.
            this.разделыTableAdapter.Fill(this.dataSet1.разделы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.разделыTableAdapter.Update(this.dataSet1.разделы);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.изданияTableAdapter.Fill(this.dataSet1.издания);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
