using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.MODEL
{
    [Serializable]
    class Prodaja
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
