using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyogynovenyek
{


    class noveny
    {

        public string Nev { get; private set; }

        public string Resz { get; private set; }

        public int kezd { get;private set; }

        public int Veg { get; private set; }

        public int Idotartam { get; private set; }



        public noveny(string szoveg)
        {
            string[] sor = szoveg.Split(';');
            Nev = sor[0];
            Resz = sor[1];
            kezd = int.Parse(sor[2]);
            Veg = int.Parse(sor[3]);

            if (Veg > kezd)
            {
                Idotartam = Veg - kezd+1;
            }
            else
            {
                Idotartam = 12 - kezd+Veg + 1;
            }

        }

    }
}
