using System.Collections.Generic;
using Salon.UTILS;
using System;
using Salon.MODEL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Salon.MODEL
{
    public class Projekat
    {
        public static Projekat Instance { get; } = new Projekat();






        private List<Namestaj> namestaj;


        public List<Namestaj> Namestaj
        {
            get
            {
                this.namestaj = GenericSerializator.Deserialize<Namestaj>("namestaj.xml");
                return this.namestaj;
            }
            set
            {
                this.namestaj = value;
                GenericSerializator.Serialize<Namestaj>("namestaj.xml", namestaj);

            }
        }
        private List<Akcija> akcija;

        public List<Akcija> Akcija
        {
            get
            {
                this.akcija = GenericSerializator.Deserialize<Akcija>("akcija.xml");
                return this.akcija;
            }
            set
            {

                this.akcija = value;
                GenericSerializator.Serialize<Akcija>("akcija.xml", akcija);
            }
        }


        private List<Salon> salon;

        public List<Salon> Salon
        {
            get
            {
                this.salon = GenericSerializator.Deserialize<Salon>("salon.xml");
                return this.salon;
            }
            set
            {

                this.salon = value;
                GenericSerializator.Serialize<Salon>("salon.xml", salon);
            }
        }

        private List<Korisnik> korisnik;

        public List<Korisnik> Korisnik
        {
            get
            {
                this.korisnik = GenericSerializator.Deserialize<Korisnik>("korisnik.xml");
                return this.korisnik;
            }
            set
            {

                this.korisnik = value;
                GenericSerializator.Serialize<Korisnik>("korisnik.xml", korisnik);
            }
        }


        private List<TipNamestaja> tipNamestaja;

        public List<TipNamestaja> TipNamestaja
        {
            get
            {
                this.tipNamestaja = GenericSerializator.Deserialize<TipNamestaja>("tipNamestaja.xml");
                return this.tipNamestaja;
            }
            set
            {

                this.tipNamestaja = value;
                GenericSerializator.Serialize<TipNamestaja>("tipNamestaja.xml", tipNamestaja);
            }
        }

        private List<Prodaja> prodaja;

        public List<Prodaja> Prodaja
        {
            get
            {
                this.prodaja = GenericSerializator.Deserialize<Prodaja>("prodaja.xml");
                return this.prodaja;
            }
            set
            {

                this.prodaja = value;
                GenericSerializator.Serialize<Prodaja>("prodaja.xml", prodaja);
            }
        }

    }
}
