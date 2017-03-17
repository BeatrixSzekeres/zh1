using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Bolha : Barna, Startpisztoly
    {
        private int labakszama = 6;
        private int sebess = 0;

        public int Lab
        {
            get
            {
                return sebesseg / labakszama;
            }

            set
            {
            }
        }

        public int Sebess
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
            sebesseg++;
        }
    }
}