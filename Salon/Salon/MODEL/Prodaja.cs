using System;
using System.Collections.Generic;

namespace Salon.MODEL
{
    [Serializable]
    public class Prodaja
    {
        public int Id { get; set; }
        public string Kupac { get; set; }
        public string BrojRacuna { get; set; }
        public Akcija Akcija { get; set; }
        public List<Namestaj> NamestajProdaja { get; set; }
        public const double PDV = 0.02;
        public double UkupanIznos { get; set; }
        public DateTime DatumKadaJeProdato { get; set; }

    }
}
