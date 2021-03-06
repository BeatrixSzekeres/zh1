﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Barna : Startpisztoly
    {
        public int sebesseg = 0;
        private int lepesszam = 0;
        private int labakszama = 4;

        public Barna(int sorszam, int sebesseg, int labatlseb)
        {
            sorszam = Sorszamok.Barna;
            labatlseb = Labsebes;
        }

        public int Labsebes
        {
            get
            {
                return sebesseg / labakszama;
            }

            set
            {
            }
        }
        public int Sebesseg
        {
            get
            {
                return sebesseg;
            }

            set
            {
            }
        }

        void Startpisztoly.Eldordules()
        {
            lepesszam++;
            sebesseg++;
        }
        void Startpisztoly.Vege() { }
    }
}