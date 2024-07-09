using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсяч
{
    class tGroup
    {
        static public tStudents[] students; 
        public tGroup(List<string> Namefiles)
        {
            Array.Resize(ref students, Namefiles.Count);
            for(int i = 0; i < Namefiles.Count; i++)
            {
                DirectoryInfo di = new DirectoryInfo(Namefiles[i]);
                FileInfo[] fi = di.GetFiles("*.jpg");
                FileInfo[] fit = di.GetFiles("*.txt");
                StreamReader sr = new StreamReader(Namefiles[i]+"\\"+fit[0], System.Text.Encoding.UTF8);
                string portrait; string name; string surname;string Group; int kurs;int otsenka1; int otsenka2;int otsenka3;string zach;
                portrait = Namefiles[i] + "\\" + fi[0];
                name = sr.ReadLine();
                surname = sr.ReadLine();
                Group= sr.ReadLine();
                try
                {
                    kurs = int.Parse(sr.ReadLine()[0].ToString());
                }
                catch 
                {
                    kurs = 0;
                }
                try
                {
                    otsenka1 = int.Parse(sr.ReadLine()[0].ToString());
                }
                catch
                {
                    otsenka1 = 0;
                }
                try
                {
                    otsenka2 = int.Parse(sr.ReadLine()[0].ToString());
                }
                catch
                {
                    otsenka2 = 0;
                }
                try
                {
                    otsenka3 = int.Parse(sr.ReadLine()[0].ToString());
                }
                catch
                {
                    otsenka3 = 0;
                }
                zach=sr.ReadLine();
                //public string ShowGroup()
                students[i] = new tStudents(portrait, name, surname,Group, kurs, otsenka1,otsenka2,otsenka3,zach);
            }
           
        }
    }
}
