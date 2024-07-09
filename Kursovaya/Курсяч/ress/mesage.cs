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
    public partial class mesage : Form
    {
        public mesage()
        {
            InitializeComponent();
            label1.Text = launch().ToString();
            System.Threading.Thread.Sleep(500);
        }
        class Show
        {
            
            //public Show(List <char> f)
            //{
            //    gol = f;
            //}

        }
        public static List<char> launch()
        {
            List<char> gol=new List<char>();
            gol.Add('Г');
            for (int i = 0; i < Form2.Num_amount(); i++)
                gol.Add('О');
            Form2.o++;
            gol.Add('Л');
            return gol;
            //mesage.S
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
