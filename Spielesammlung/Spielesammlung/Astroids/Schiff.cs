using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielesammlung.Astroids
{
    class Schiff : Figuren
    {
        public int richtung = 0;
        public Schwung geschwindigkeit;

        public Schiff()
        {

        }

        public void LinksDreh()
        {

        }

        public void RechtsDreh()
        {

        }

        public Schwung Beschleunigung(Schwung aktuelleGeschwindigkeit)
        {
            return(new Schwung());
        }

        public Schwung Bremsen(Schwung aktuelleGeschwindigkeit)
        {
            return (new Schwung());
        }

        public void Schiessen()
        {

        }
    }
}
