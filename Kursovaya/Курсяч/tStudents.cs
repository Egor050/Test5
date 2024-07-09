using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсяч
{
    class tStudents
    {
        string portrait, name, surname, group, zach;
        int kurs, otsenka1,otsenka2,otsenka3;
        public tStudents(string a3,string a, string b,string v, int c,int d1,int d2,int d3, string z)
        {
            portrait = a3;
            name = a;
            surname = b;
            group = v;
            kurs = c;
            otsenka1 = d1;
            otsenka2 = d2;
            otsenka3 = d3;
            zach= z;
        }
        public string Portrait()
        {
            return portrait;
        }
        public string Name()
        {
            return name;
        }
        public string Surname()
        {
            return surname;
        }
        public string Group()
        {
            return group;
        }
        public int Kurs()
        {
            return kurs;
        }
        public int Otsenka1()
        {
            return otsenka1;
        }
        public int Otsenka2()
        {
            return otsenka2;
        }
        public int Otsenka3()
        {
            return otsenka3;
        }
        public string Zach()
        {
            return zach;
        }
    }
}
