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
            Samochod sam1 = new Samochod(5, "Fiat", "126p", "pomaranczowy", "0.65", false, false, false, "126Pomaranczowy");
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

        public List<String> PodajSilniki(String jakaMarka , String jakiModel)
        {
            List<String> silniki = new List<string>();
            silniki = lista.PodajSilniki(jakaMarka, jakiModel).Distinct().ToList(); //usuwa duplikaty

            return silniki;
        }



        public List<String> PodajKolory(String jakaMarka, String jakiModel, String jakiSilnik, bool czyMetalic)
        {
            List<String> kolory = new List<string>();
            kolory = lista.PodajKolory(jakaMarka, jakiModel, jakiSilnik, czyMetalic).Distinct().ToList(); //usuwa duplikaty

            return kolory;
        }

        public String PodajZdjecie(String jakaMarka, String jakiModel, String jakiSilnik, String jakiKolor)
        {
            String zdjecie = "";
            zdjecie = lista.PodajZdjecie(jakaMarka, jakiModel, jakiSilnik, jakiKolor); //usuwa duplikaty

            return zdjecie;
        }



    }
}
