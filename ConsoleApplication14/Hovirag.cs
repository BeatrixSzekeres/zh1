using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Hovirag : Startpisztoly
    {
        private int sebesseg = 0;
        public bool  Eldordules()
        {
            throw new NotImplementedException();
        }

        public void FoldbeGyokerezik()
        {
            
            if (Eldordules() == true)
            {
                 sebesseg = 0;
            }

        }

        void Startpisztoly.Eldordules()
        {
            throw new NotImplementedException();
        }
    }
}