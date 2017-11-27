using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisSamochodowy
{

    public enum kolory
    {
        biały,
        czerwony,
        zielony,
        srebrny,
        szary
    }

    public enum kolory_metalic
    {
        srebrny,
        szary
    }

    class Samochod
    {
        public uint Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        //private kolory Kolor { get; set; }
        public string Kolor { get; set; }
        public string Pojemnosc { get; set; }
        public bool Metalic { get; set; }

        public bool Klimatyzacja { get; set; }
        public bool Alarm { get; set; }

        public Samochod(uint _id, string _marka, string _model, string _kolor, string _pojemnosc,
                        bool _metalic, bool _klima, bool _alarm)
        {
            Id = _id;
            Marka = _marka;
            Model = _model;
            Kolor = _kolor;
            Pojemnosc = _pojemnosc;
            Metalic = _metalic;
            Klimatyzacja = _klima;
            Alarm = _alarm;

        }




    }
}
