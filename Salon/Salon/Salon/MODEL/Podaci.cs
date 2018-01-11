using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Salon.MODEL;
using Salon.UI;

namespace Salon.MODEL
{
    public class Podaci
    {
        public const string CONNECTION_STRING = @"Data Source=DESKTOP-7L9QPCU;Initial Catalog=SalonDB;Integrated Security=True";

        public ObservableCollection<Namestaj> Namestaj { get; set; }
        public ObservableCollection<Akcija> Akcija { get; set; }
        public ObservableCollection<TipNamestaja> TipoviNamestaja { get; set; }
        public ObservableCollection<Korisnik> Korisnik { get; set; }
        public ObservableCollection<Korisnik> KorisniciPodaci { get; set; }
        public ObservableCollection<TipKorisnika> TipoviKorisnika { get; set; }
        public ObservableCollection<DodatnaUsluga> DodatnaUsluga { get; set; }
        public ObservableCollection<Prodaja> Prodaja { get; set; }
        public ObservableCollection<Salon> PodaciOSalonu { get; set; }

        //public Salon PodaciOSalonu { get; set; }

        //singleton pattern; Jedan objekat klase Aplikacija postoji u celom programu. Svi delovi programa koriste ovaj objekat
        private static Podaci instance = new Podaci();

         public static Podaci Instance
        {
            get
            {
                return instance;
            }
        }
        private Podaci()
        {
            Namestaj = MODEL.Namestaj.UcitajNamestaj();
            Akcija = new ObservableCollection<MODEL.Akcija>();
            TipoviNamestaja = new ObservableCollection<MODEL.TipNamestaja>();
            Korisnik = new ObservableCollection<MODEL.Korisnik>();
            KorisniciPodaci = new ObservableCollection<MODEL.Korisnik>();
           // PodaciOSalonu = MODEL.Salon.UcitajPodatke();
           // PodaciOSalonu = new ObservableCollection<Salon>();
            TipoviKorisnika = new ObservableCollection<MODEL.TipKorisnika>();
            //DodatnaUsluga = new ObservableCollection<MODEL.DodatnaUsluga>();
            DodatnaUsluga = MODEL.DodatnaUsluga.UcitajUsluge();
            Prodaja = new ObservableCollection<MODEL.Prodaja>();

        }
        public void UcitajIzBaze()
        {
            MODEL.DodatnaUsluga.UcitajUsluge();
            MODEL.Korisnik.UcitajKorisnike();
            MODEL.Namestaj.UcitajNamestaj();
            //MODEL.Salon.UcitajPodatke();
        }
        /*
        public static Korisnik UlogovanKor = null;
        public static bool AdminLog = false;
        public static bool LogInForm = true;
        public static bool DB = false;
        */
    }
}
