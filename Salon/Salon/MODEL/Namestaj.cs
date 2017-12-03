using System;


namespace Salon.MODEL
{
    [Serializable]
    public class Namestaj
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public string Sifra { get; set; }

        public double Cena { get; set; }

        public int Kolicina { get; set; }
        public int TipNamestajaId { get; set; }

        public override string ToString()
        {
            return $"{ Naziv}, { Cena }, { Kolicina },{ TipNamestajaId }";
        }

        public static Namestaj GetById(int id)
        {
            foreach (var namestaj in Projekat.Instance.Namestaj)
            {
                if (namestaj.Id == id)
                {
                    return namestaj;
                }
            }
            return null;
        }

        public bool Obrisan { get; set; }

        public Akcija Akcija { get; set; }

        

        
        

        

    }
}
