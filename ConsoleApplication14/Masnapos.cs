using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Masnapos : Startpisztoly
    {
        public int lepesszam = 0;
        private int sebesseg = 0;
        private int labakszama = 4;

        public Masnapos(int sorszam, int sebesseg, int labatlseb)
        {
            sorszam = Sorszamok.Masnapos;
            labatlseb = Lab;
        }

        public int Lab
        {
            get
            {
                return sebesseg/labakszama;
            }

            set
            {
            }
        }   

        public void Elorelepes()
        {
            lepesszam = lepesszam + 2;
            sebesseg++;
        }

        public void Hatralepes()
        {
            lepesszam--;
            sebesseg = 0;
        }

        public void MegallLevegozni()
        {
            sebesseg = 0;
        }

        

        void Startpisztoly.Eldordules()
        {
            sebesseg++;
        }
        void Startpisztoly.Vege() { }
    }
}