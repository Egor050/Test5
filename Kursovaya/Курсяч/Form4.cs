using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсяч
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2();
            result.Show();
            result.Location = this.Location;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 result = new Form1(); //создаем экземпляр класса Form2
            result.Show(); //отображаем форму с результатом
            result.Location = this.Location; //открытая форма сохраняет расположение главной формы
            this.Hide(); //скрываем главную форму
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
