using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSoftWettbewerb {
    internal class Sportler {
        private string name;
        public Sportler(string n) {
            this.name = n;
        }

        public string getName() {
            return name;
        }
    }
}
