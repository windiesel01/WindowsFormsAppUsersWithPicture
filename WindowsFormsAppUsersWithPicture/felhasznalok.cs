using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUsersWithPicture
{
    internal class felhasznalok
    {
        int id;
        string nev;
        string szuletes;
        string kep;


        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Szuletes { get => szuletes; set => szuletes = value; }
        public string Kep { get => kep; set => kep = value; }

        public felhasznalok(int id, string nev, string szuletes, string kep)
        {
            Id = id;
            Nev = nev;
            Szuletes = szuletes;
            Kep = kep;
        }

        public override string ToString()
        {
            return $"{nev} - [{szuletes}] - ({kep})";
        }
    }
}
