using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KomisSamochodowy
{
    class ListaSamochodow
    {
        //ArrayList listaSamochodow = new ArrayList();
        public List<Samochod> listaSam = new List<Samochod>();

        public ListaSamochodow()
        {
            //this.listaSam = new List<Samochod>();
            Samochod sam1 = new Samochod(1, "Fiat", "126p", "pomaranczowy", "0.65", false, false, false, "126Pomaranczowy");
            Samochod sam2 = new Samochod(2, "Fiat", "Tipo", "Szary", "1.6", true, true, true, "TipoSzary");
            Samochod sam3 = new Samochod(3, "Fiat", "Tipo", "Czarny", "1.9", true, true, false, "TipoCzarny");
            Samochod sam4 = new Samochod(4, "Skoda", "Fabia", "niebieski", "1.4", false, false, true, "FabiaNiebieska");
            Samochod sam5 = new Samochod(5, "Skoda", "Fabia", "czerwony", "1.4", false, false, false, "FabiaCzerwony");
            Samochod sam6 = new Samochod(6, "Skoda", "Fabia", "czarny", "1.4", false, false, true, "FabiaCzarny");
            Samochod sam7 = new Samochod(7, "Skoda", "Fabia", "bialy", "1.4", false, false, false, "FabiaBialy");
            Samochod sam8 = new Samochod(8, "Skoda", "Fabia", "zielony", "1.2", true, true, true, "FabiaZielony");
            Samochod sam9 = new Samochod(8, "Skoda", "Fabia", "czerwony", "1.2", true, true, false, "FabiaCzerwony");
            Samochod sam10 = new Samochod(9, "Skoda", "Octavia", "zielony", "1.6", true, true, true, "OctaviaZielony");
            Samochod sam11 = new Samochod(10, "Skoda", "Octavia", "bialy", "1.9", true, true, false, "OctaviaCzerwony");
            listaSam.Add(sam1);
            listaSam.Add(sam2);
            listaSam.Add(sam3);
            listaSam.Add(sam4);
            listaSam.Add(sam5);
            listaSam.Add(sam6);
            listaSam.Add(sam7);
            listaSam.Add(sam8);
            listaSam.Add(sam9);
            listaSam.Add(sam10);
            listaSam.Add(sam11);

        }

        public void DodajSamochod(Samochod sam)
        {
            listaSam.Add(sam);

        }


        public List<String> PodajListeMarek()
        {
            List<String> markiNaLiscie = new List<string>();

            foreach (Samochod sam in listaSam)
            {
                markiNaLiscie.Add(sam.Marka);
            }

            return markiNaLiscie;

        }


        public List<String> PodajListeModeli(string marka)
        {
            List<String> modele = new List<string>();

            foreach (Samochod sam in listaSam)
            {
                if(sam.Marka == marka)
                    modele.Add(sam.Model);

            }

            return modele;

        }

        public List<String> PodajSilniki(string marka, string model)
        {
            List<String> silniki = new List<string>();

            foreach (Samochod sam in listaSam)
            {
                if ((sam.Marka == marka) && (sam.Model == model))
                    silniki.Add(sam.Pojemnosc);

            }

            return silniki;

        }


        public List<String> PodajKolory(string marka, string model, string silnik, bool metalic)
        {
            List<String> kolory = new List<string>();

            foreach (Samochod sam in listaSam)
            {
                if ((sam.Marka == marka) && (sam.Model == model) && (sam.Pojemnosc == silnik) && (sam.Metalic == metalic))
                    kolory.Add(sam.Kolor);

            }

            return kolory;

        }


        public String PodajZdjecie(string marka, string model, string silnik, string kolor)
        {
            String zdjecie = "";

            foreach (Samochod sam in listaSam)
            {
                if ((sam.Marka == marka) && (sam.Model == model) && (sam.Pojemnosc == silnik) && (sam.Kolor == kolor))
                    zdjecie = sam.Zdjecie;

            }

            return zdjecie;

        }



        


    }
}

