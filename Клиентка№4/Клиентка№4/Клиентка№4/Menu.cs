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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            s.Owner = this;
            button1.Visible = false;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Модель s = new Модель();
            s.Show();
            s.Owner = this;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Заказ s = new Заказ();
            s.Show();
            s.Owner = this;
            button2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Поставка s = new Поставка();
            s.Show();
            s.Owner = this;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Должность s = new Должность();
            s.Show();
            s.Owner = this;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Клиенты s = new Клиенты();
            s.Show();
            s.Owner = this;
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Марка s = new Марка();
            s.Show();
            s.Owner = this;
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Поставщик s = new Поставщик();
            s.Show();
            s.Owner = this;
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Прием_на_работу s = new Прием_на_работу();
            s.Show();
            s.Owner = this;
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Производители s = new Производители();
            s.Show();
            s.Owner = this;
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Склад s = new Склад();
            s.Show();
            s.Owner = this;
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Сотрудник s = new Сотрудник();
            s.Show();
            s.Owner = this;
            button12.Visible = false;
        }
    }
}
