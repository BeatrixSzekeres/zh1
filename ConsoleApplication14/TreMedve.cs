using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class TreMedve : Startpisztoly
    {
        private int labakSzama = 4;
        private int sebesseg;

        public TreMedve(int Sorszam,int Sebesseg,int labatlseb)
        {
            Sorszam = Sorszamok.TreMedve;
            labatlseb = LabSebesseg;
        }

        public int LabSebesseg
        {

            get
            {
                return sebesseg/labakSzama;
            }

            set
            {
                throw new NotImplementedException();
            }
        }
            
            public virtual bool Elorditas()
        {
            if (Elorditas() == true)
                return true;
            else
                return false;
        }
        

        public void Eldordules()
        {
            throw new NotImplementedException();
        }
    }

        

        
    }
