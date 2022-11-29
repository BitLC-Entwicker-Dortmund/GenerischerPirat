using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerischerPirat {
    class Program {
        static void Main ( string [ ] args ) {

            // die Getränke - Zuweisung von Werten über der Standardkonstruktor
            Scumm s = new Scumm ( );
            Rum rum1 = new Rum ( ) { Name = "Brauner Rum" , Farbe = "hellbaun" , Herkunft = "Cuba" }; 
            Rum rum2 = new Rum ( ) { Name = "Weisser Rum" , Farbe = "durchsichtig" , Herkunft = "Östereich" };

            // erschaffe Faschen
            Flasche<Rum> Rumflasche1 = new Flasche<Rum>();
            Flasche<Rum> Rumflasche2 = new Flasche<Rum>();
            Flasche<Scumm> ScummFlasche = new Flasche<Scumm> ( );

            // Fülle Flaschen mit Getränken
            Rumflasche1.Trinkbares = rum1;
            Rumflasche2.Trinkbares = rum2;
            ScummFlasche.Trinkbares = s;
            
            // erschaffe den Piraten
            Pirat<Getraenk> wolfgang = new Pirat<Getraenk> ( );

            // konsumierender Pirat
            wolfgang.GetraenkIntus = Rumflasche1.Trinkbares;
            //Rumflasche1.Trinkbares = null;  // Flasche léer ...

            Console.WriteLine ("Wolfgang was ist in Dir drin: {0}", wolfgang.GetraenkIntus.Name);
            Console.WriteLine ("W sieht sich die Flashce an und sagt:" +
                "Genauer: {0} Farbe: {1} aus {2}", Rumflasche1.Trinkbares.Name, 
                Rumflasche1.Trinkbares.Farbe, Rumflasche1.Trinkbares.Herkunft);
            Console.Read ( );
        }
    }
}
