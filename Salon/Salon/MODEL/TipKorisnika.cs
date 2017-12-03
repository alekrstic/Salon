using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salon.MODEL;
namespace Salon

{
    [Serializable]
    public class TipKorisnika
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public bool Obrisan { get; set; }


        public TipKorisnika(int Id, string Naziv, bool Obrisan)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.Obrisan = Obrisan;
        }


        public override string ToString()
        {
            return Naziv;
        }
        public TipKorisnika()
        {

        }
    }
}
