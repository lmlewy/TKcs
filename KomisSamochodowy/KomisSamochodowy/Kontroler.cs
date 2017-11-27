using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{
    class Kontroler
    {

        ListaSamochodow lista = new ListaSamochodow();

        public void DodajSamochod()
        {
            Samochod sam1 = new Samochod(5, "Fiat", "126p", "pomaranczowy", "0.65", false, false, false);
            lista.DodajSamochod(sam1);

        }

        public List<String> PodajMarki()
        {
            List<String> marki = new List<string>();
            marki = lista.PodajListeMarek().Distinct().ToList(); //usuwa duplikaty

            return marki;
        }

        public List<String> PodajModele(String jakaMarka)
        {
            List<String> modele = new List<string>();
            modele = lista.PodajListeModeli(jakaMarka).Distinct().ToList(); //usuwa duplikaty

            return modele;
        }


        public List<String> PodajKolory(String jakaMarka, String jakiModel)
        {
            List<String> kolory = new List<string>();
            kolory = lista.Podajkolory(jakaMarka, jakiModel).Distinct().ToList(); //usuwa duplikaty

            return kolory;
        }


    }
}
