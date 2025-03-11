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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.издания". При необходимости она может быть перемещена или удалена.
            this.изданияTableAdapter.Fill(this.dataSet1.издания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.dataSet1.читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.издания". При необходимости она может быть перемещена или удалена.
            this.изданияTableAdapter.Fill(this.dataSet1.издания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.dataSet1.читатели);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.издания". При необходимости она может быть перемещена или удалена.
            this.изданияTableAdapter.Fill(this.dataSet1.издания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.читатели". При необходимости она может быть перемещена или удалена.
            this.читателиTableAdapter.Fill(this.dataSet1.читатели);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
