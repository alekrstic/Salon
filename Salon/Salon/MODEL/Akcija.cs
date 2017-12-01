using System;
using System.Collections.Generic;

namespace Salon.MODEL
{
    [Serializable]
    class Akcija
    {
        public int Id { get; set; }

        public DateTime DatumPocetka { get; set; }

        public DateTime DatumZavrsetka { get; set; }

        public decimal Popust { get; set; }
        public bool Obrisan { get; set; }
       public List<Namestaj> NamestajPopust { get; set; }
    }
}
