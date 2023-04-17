using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSoftWettbewerb {
    internal class Ergebnis {
        private Sportler sportler;
        private float erg;

        public Ergebnis(Sportler s, float ergebnis) { 
            this.sportler = s;
            this.erg = ergebnis;
        }
        public Sportler getSportler() {
            return sportler;
        }
        public float getErg() {
            return erg;
        }
    }
}
