using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerischerPirat {

    class Scumm : Getraenk {
        public Rum Rum { get; set; }
        public Maschinenoel Maschinenoel { get; set; }
        public Schwarzpulver Schwarzpulver { get; set; }
        public Kerosin Kerosin { get; set; }

        public Scumm ( ) {
            Rum = new Rum ( );
            Maschinenoel = new Maschinenoel ( );
            Schwarzpulver = new Schwarzpulver ( );
            Kerosin = new Kerosin ( );
        }
    }
}
