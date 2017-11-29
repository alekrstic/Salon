using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.MODEL
{
    [Serializable]
    class Salon
    {
        public int Id { get; set; }

        public bool Obrisan { get; set; }

        public string Naziv { get; set; }

        public string Adresa { get; set; }

        public string Telefon { get; set; }

        public string Email { get; set; }

        public string Sajt_adresa { get; set; }

        public int PIB { get; set; }

        public int Maticni_broj { get; set; }

        public string Ziro_racun { get; set; }
    }
}
