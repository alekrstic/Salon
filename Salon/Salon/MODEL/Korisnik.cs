using System;

namespace Salon.MODEL
{
    [Serializable]

public enum TipKorisnika
{
    Admin,
    Prodavac
}

    class Korisnik
    {
    public int Id { get; set; }

    public string Ime { get; set; }

    public string Prezime { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public TipKorisnika Tip_Korisnika { get; set; }

    public bool Obrisan { get; set; }
    
       

    }
}
