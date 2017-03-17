using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Masnapos : Startpisztoly
    {
        private int sebesseg = 0;
        private int labakszama = 4;
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

        public void Eldordules()
        {
            throw new NotImplementedException();
        }

        public void Elorelepes()
        {
            throw new System.NotImplementedException();
        }

        public void Hatralepes()
        {
            throw new System.NotImplementedException();
        }

        public void MegallLevegozni()
        {
            throw new System.NotImplementedException();
        }

        public void Sebesseg()
        {
            throw new System.NotImplementedException();
        }
    }
}