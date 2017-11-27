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
            Samochod sam1 = new Samochod(1, "Fiat", "126p", "pomaranczowy", "0.65", false, false, false);
            Samochod sam2 = new Samochod(2, "Skoda", "Fabia", "niebieski", "1.4", false, false, true);
            Samochod sam3 = new Samochod(3, "Skoda", "Fabia", "zielony", "1.2", true, true, true);
            Samochod sam4 = new Samochod(3, "Skoda", "Octavia", "zielony", "1.6", true, true, true);
            listaSam.Add(sam1);
            listaSam.Add(sam2);
            listaSam.Add(sam3);
            listaSam.Add(sam4);
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

        public List<String> Podajkolory(string marka, string model)
        {
            List<String> kolory = new List<string>();

            foreach (Samochod sam in listaSam)
            {
                if ((sam.Marka == marka) && (sam.Model == model))
                    kolory.Add(sam.Kolor);

            }

            return kolory;

        }






        


    }
}

