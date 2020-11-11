using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Клиентка_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klientDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klientDataSet.Производители". При необходимости она может быть перемещена или удалена.
            this.производителиTableAdapter.Fill(this.klientDataSet.Производители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klientDataSet.Детали". При необходимости она может быть перемещена или удалена.
            this.деталиTableAdapter.Fill(this.klientDataSet.Детали);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klientDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            //this.поставщикTableAdapter.Fill(this.klientDataSet.Поставщик);

        }

        private void деталиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.деталиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.klientDataSet);

        }

        private void деталиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            this.Validate();
            this.деталиBindingSource.EndEdit();
            Menu f1 = this.Owner as Menu;
            f1.button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            деталиBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            деталиBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            деталиBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.деталиBindingSource.EndEdit();
            деталиBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            деталиBindingSource.RemoveCurrent();
            this.Validate();
            this.деталиBindingSource.EndEdit();
        }
    }
}
