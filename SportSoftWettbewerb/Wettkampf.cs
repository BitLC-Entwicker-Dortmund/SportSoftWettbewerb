using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSoftWettbewerb {
    internal abstract class Wettkampf {
        private List<Sportler> sportlerListe = new List<Sportler>();
        private List<Ergebnis> ergebnisListe = new List<Ergebnis>();
        private Disziplin disziplin;

        public Wettkampf(Disziplin diszi) {
            this.disziplin = diszi;
        }

        public void addSportler(Sportler s) {
             sportlerListe.Add(s);
        }

        public void addErgebnis(Sportler s, float ergebnis) {
            Ergebnis ergObjekt = new Ergebnis(s, ergebnis);
            ergebnisListe.Add(ergObjekt);
        }

        public void ausgabe() {
            foreach (Ergebnis  einErgebnis in ergebnisListe) {
                Console.WriteLine(einErgebnis.getSportler().getName() + " " +einErgebnis.getErg());
            }
        }
    }
}
