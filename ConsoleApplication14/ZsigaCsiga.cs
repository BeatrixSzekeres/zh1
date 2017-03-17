using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class ZsigaCsiga : TreMedve, Startpisztoly
    {
        public ZsigaCsiga()
        {
            throw new System.NotImplementedException();
        }

        public void Sebesseg()
        {
            throw new System.NotImplementedException();
        }


        void Startpisztoly.Eldordules()
        { }
        void Startpisztoly.Vege() { }

        public void HazabaKenyszerul()
        {
            if (Elorditas() == true)
                sebesseg = 0;
            else
                sebesseg++;
        }

        private int sebesseg = 1;
    }
}