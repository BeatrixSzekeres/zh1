﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class CsacskaNyul : TreMedve, Startpisztoly
    {
        private int labakszama = 4;
        private double sebesseg=0;

        public CsacskaNyul(int Sorszam, int sebesseg, double labatlseb)
        {
            Sorszam = Sorszamok.CsacskaNyul;
            labatlseb = LabSeb;
        }

        public double LabSeb
        {
            get
            {
                return sebesseg/labakszama;
            }

            set
            {
            }
        }
        

        public void Sebesseg()
        {
            if (Elorditas() == true)
                sebesseg = sebesseg * 1.5;
            
        }
        void Startpisztoly.Eldordules()
        {
            sebesseg++;
        }
        void Startpisztoly.Vege() { }
    }
}