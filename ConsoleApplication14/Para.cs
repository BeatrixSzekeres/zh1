using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Para : Startpisztoly
    {
        private int lepesszam = 0;
        private int labakSzAma = 4;
        private int sebesseg = 0;
        public int Lab
        {
            get
            {
                return sebesseg / labakSzAma;
            }

            set
            {
            }
        }
        public void Varakozas()
        {

            sebesseg = 0;
        }

        public void Atsprinteles()
        {
            lepesszam++;
            sebesseg++;
        }


    }
}