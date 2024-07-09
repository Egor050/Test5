using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;


namespace Курсяч
{
    public partial class Form3 : Form
    {
        bool click = false;
        bool a = false;
        int q = 0, p1 = 0, p2= 0, p3 = 0;
        private string pathPic;
        string path;
        string sw0;
        public Form3()
        {
            InitializeComponent();
            Create();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            q++;
            if (q > 5)
                q--;
            label5.Text = q.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            q--;
            if (q < 0)
                q++;
            label5.Text = q.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p1++;
            if (p1 > 5)
                p1--;
            label6.Text = p1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p1--;
            if (p1 < 0)
                p1++;
            label6.Text = p1.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathPic = openFileDialog1.FileName;                
                    a = true;
                    pictureBox1.Image = new Bitmap(pathPic);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;             
            }        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (click == false)
                    Directory.Delete(path, true);
                Form1 result = new Form1(); //создаем экземпляр класса Form2
                result.Show(); //отображаем форму с результатом
                result.Location = this.Location; //открытая форма сохраняет расположение главной формы
                this.Hide(); //скрываем главную форму
            }
            catch
            {
                MessageBox.Show("Ошибка компилятора, попробуйте ещё раз");
            }
           
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            click = true;
            if (textBox1.Text == "" | textBox2.Text == ""|textBox3.Text=="")
            {
                System.Windows.Forms.MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(path);
                try
                {
                    Write();
                    if (a == true)
                    {
                        File.Copy(pathPic, path + "\\портрет.jpg", true);
                    }
                    Class2.RenameTo(di, textBox1.Text + " " + textBox2.Text);
                    path = Path() + "\\" + textBox1.Text + " " + textBox2.Text;
                    sw0 = path + "\\Новый текстовый документ.txt";
                }
                catch
                {
                    MessageBox.Show("Ошибка компилятора, попробуйте ещё раз");
                }
            }
        } 
        private void button8_Click(object sender, EventArgs e)
        {
            p2++;
            if (p2 > 5)
                p2--;
            label8.Text = p2.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            p2--;
            if (p2 < 0)
                p2++;
            label8.Text = p2.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p3++;
            if (p3 > 5)
                p3--;
            label10.Text = p3.ToString();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            p3--;
            if (p3 < 0)
                p3++;
            label10.Text = p3.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label13.Text = "Сдал";
        }
        private void button13_Click(object sender, EventArgs e)
        {
        label13.Text = "Не Сдал";
        }

        private void Write()
        {
            StreamWriter sw = new StreamWriter(sw0);
            sw.WriteLine(textBox1.Text);
            sw.WriteLine(textBox2.Text);
            sw.WriteLine(textBox3.Text);
            string a = label5.Text + " Курс";
            sw.WriteLine(a);
            sw.WriteLine(label6.Text);
            sw.WriteLine(label8.Text);
            sw.WriteLine(label10.Text);
            sw.WriteLine(label13.Text);
            sw.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (click == false)
                    Directory.Delete(path, true);
            }
            catch { }        
            Application.Exit();
        }

        private void Write1()
        {
            StreamWriter sw = new StreamWriter(sw0);
            sw.WriteLine("null");
            sw.WriteLine("null");
            sw.WriteLine("0");
            sw.WriteLine("0");
            sw.Close();
        }
        private string Path()
        {
            string p = Class1.Pathh() + "\\Студенты";
            return p;
        }

        protected void Create()
        {
            if (Directory.Exists(Path() + "\\Новая папка") == true)
            {
                bool check = false; int i = 1;
                do
                {
                    if (Directory.Exists(Path() + "\\" + "Новая папка (" + i+")") == false)
                    {
                        check = true;
                        Directory.CreateDirectory(Path() + "\\" + "Новая папка (" + i+")");
                        path = Path() + "\\" + "Новая папка (" + i + ")";
                        Directory.CreateDirectory(Path() + "\\" + textBox1.Text + "" + textBox2.Text);
                        sw0 = Path() + "\\" + "Новая папка (" + i + ")\\Новый текстовый документ.txt";
                        File.Create(sw0);
                        File.Create(Path() + "\\" + "Новая папка (" + i + ")\\портрет.jpg");
                    }
                    i++;
                } while (check == false);
            }
            else
            {
                Directory.CreateDirectory(Path() + "\\Новая папка");
                path = Path() + "\\Новая папка";
                sw0 = Path() + "\\" + "Новая папка" + "\\Новый текстовый документ.txt";
                File.Create(sw0);
                File.Create(Path() + "\\" + "Новая папка" + "\\портрет.jpg");
            }                    
        }  
    }
}
