using System;


namespace Salon.MODEL
{
    [Serializable]
    class Namestaj
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Sifra { get; set; }

        public double Cena { get; set; }

        public int Kolicina { get; set; }
        public int TipNamestajaId { get; set; }

        public bool Obrisan { get; set; }

        public Akcija Akcija { get; set; }

        

        public override string ToString()
        {
            return $"{Naziv},{Sifra},{Cena},{TipNamestajaId}";
        }

        

    }
}
