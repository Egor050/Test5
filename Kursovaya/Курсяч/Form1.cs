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

namespace Курсяч
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadData();
        }
        // метод выводит данные в listView1
        //private void LoadData()
        //{
        //    // очищаем listView1
        //    listView1.Items.Clear();

        //    // создаем список изображений для строк listView1
        //    ImageList imageList = new ImageList();

        //    // устанавливаем размер изображений
        //    imageList.ImageSize = new Size(30, 30);

        //    // заполняем список изображениями
        //    imageList.Images.Add(new Bitmap("images/1.jpg"));
        //    imageList.Images.Add(new Bitmap("images/2.jpg"));

        //    // создадим пустое изображение (просто белая заливка)
        //    Bitmap emptyImage = new Bitmap(30, 30);

        //    // получим объект Graphics для редактирования изображения
        //    using (Graphics gr = Graphics.FromImage(emptyImage))
        //    {
        //        // выполним заливку изображения emptyImage белым цветом
        //        gr.Clear(Color.White);
        //    }

        //    // и добавим его в список
        //    imageList.Images.Add(emptyImage);

        //    // устанавливаем в listView1 список изображений imageList
        //    listView1.SmallImageList = imageList;

        //    // массив имен, которые будем выводить в listView1
        //    string[] firstNames = { "Иван", "Николай", "Егор" };

        //    // массив фамилий, которые будем выводить в listView1
        //    string[] lastNames = { "Иванов", "Николаев", "Егоров" };

        //    // добавляем строки в listView1
        //    for (int i = 0; i < firstNames.Length; i++)
        //    {
        //        // создадим объект ListViewItem (строку) для listView1
        //        ListViewItem listViewItem = new ListViewItem(new string[] { "", firstNames[i], lastNames[i] });

        //        // индекс изображения из imageList для данной строки listViewItem
        //        listViewItem.ImageIndex = i;

        //        // добавляем созданный элемент listViewItem (строку) в listView1
        //        listView1.Items.Add(listViewItem);
        //    }
        //}
        private void LoadData()
        {
            listView1.Items.Clear();
            string path = Class1.Pathh()+"\\Студенты";
            //string path = "D:\\Студенты";
            List<string> NameFiles = new List<string>(Directory.EnumerateDirectories(path));
            //DirectoryInfo di = new DirectoryInfo(path);
            //FileInfo[] fi = di.EnumerateDirectories
            ImageList image = new ImageList();
            image.ImageSize = new Size(80, 80);
            List<string> name = new List<string>();
            List<string> surname = new List<string>();
            List<string> Group = new List<string>();
            List<int> kurs = new List<int>();
            List<int> otsenka1 = new List<int>();
            List<int> otsenka2 = new List<int>();
            List<int> otsenka3 = new List<int>();
            List<string> zach = new List<string>();
            tGroup group = new tGroup(NameFiles);
            for (int i = 0; i < tGroup.students.Length; i++)
            {
                try
                {
                    image.Images.Add(new Bitmap(tGroup.students[i].Portrait()));
                }
                catch
                {
                    Bitmap emptyImage = new Bitmap(80, 80);
                    image.Images.Add(emptyImage);
                    //image.Images.Add(new Bitmap(DefaulPic()));
                }            
                name.Add(tGroup.students[i].Name());
                surname.Add(tGroup.students[i].Surname());
                Group.Add(tGroup.students[i].Group());
                kurs.Add(tGroup.students[i].Kurs());
                otsenka1.Add(tGroup.students[i].Otsenka1());
                otsenka2.Add(tGroup.students[i].Otsenka2());
                otsenka3.Add(tGroup.students[i].Otsenka3());
                zach.Add(tGroup.students[i].Zach());
            }
            listView1.SmallImageList = image;
            for (int i = 0; i < NameFiles.Count; i++)
            {
                // создадим объект ListViewItem (строку) для listView1
                ListViewItem listViewItem = new ListViewItem(new string[] { "", name[i], surname[i],Group[i], kurs[i].ToString(), otsenka1[i].ToString(), otsenka2[i].ToString(), otsenka3[i].ToString(), zach[i] });

                // индекс изображения из imageList для данной строки listViewItem
                listViewItem.ImageIndex = i;

                // добавляем созданный элемент listViewItem (строку) в listView1
                listView1.Items.Add(listViewItem);
            }
            label2.Visible = true;
            label3.Text = NameFiles.Count.ToString();
            label3.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 result = new Form2(); //создаем экземпляр класса Form2
            result.Show(); //отображаем форму с результатом
            result.Location = this.Location; //открытая форма сохраняет расположение главной формы
            this.Hide(); //скрываем главную форму
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 result = new Form3(); //создаем экземпляр класса Form2
            result.Show(); //отображаем форму с результатом
            result.Location = this.Location; //открытая форма сохраняет расположение главной формы
            this.Hide(); //скрываем главную форму
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Path;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Path = folderBrowserDialog1.SelectedPath;
                Class1.path = Path;  
            }
        }
        private void listView1_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            this.listView1.ListViewItemSorter = new ListViewColumnComparer(e.Column);
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
