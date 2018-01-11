using System;
using System.ComponentModel;
//using ValidationTest;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using Salon.MODEL;

namespace Salon.MODEL
{
    //[Serializable]




    public class Korisnik 
        
        //: INotifyPropertyChanged, ICloneable
    {
        /*
        public event PropertyChangedEventHandler PropertyChanged;
        public enum TipKorisnika { Admin, Prodavac };

        private int id;
        private String ime;
        private String prezime;
        private String username;
        private String password;
        private Boolean obrisan;
        private TipKorisnika tipKorisnika;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");

            }
        }
        public String Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                OnPropertyChanged("Ime");
            }
        }

        public String Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                OnPropertyChanged("Prezime");
            }
        }

        public String Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public String Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public Boolean Obrisan
        {
            get { return obrisan; }
            set
            {
                obrisan = value;
                OnPropertyChanged("Obrisan");
            }
        }

        public TipKorisnika Tip_Korisnika
        {
            get { return tipKorisnika; }
            set
            {
                tipKorisnika = value;
                OnPropertyChanged("TipKorisnika");
            }
        }
        public object Clone()
        {
            return new Korisnik()
            {
                id = Id,
                ime = Ime,
                prezime = Prezime,
                username = username,
                password = Password,
                obrisan = Obrisan,
                tipKorisnika = Tip_Korisnika
            };
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        */
        /*public override string ToString()
        {
            return Ime + ", " + Prezime + ", " + tipKorisnika;
        }*/

         public int Id { get; set; }

         public string Ime { get; set; }

         public string Prezime { get; set; }

         public string Username { get; set; }

         public string Password { get; set; }

         public TipKorisnika Tip_Korisnika { get; set; }

         public bool Obrisan { get; set; }


        public static void UcitajKorisnike()
        {
            using (SqlConnection connection = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand korCommand = connection.CreateCommand();
                korCommand.CommandText = @"SELECT * FROM KORISNIK";
                SqlDataAdapter daKor = new SqlDataAdapter();
                daKor.SelectCommand = korCommand;
                daKor.Fill(ds, "Korisnik"); //izvrsavanje upita

                foreach (DataRow row in ds.Tables["Korisnik"].Rows)
                {
                    Korisnik k = new Korisnik();
                    int Id = (int)row["Id"];
                    k.Ime = (string)row["Ime"];
                    k.Prezime = (string)row["Prezime"];
                    k.Username = (string)row["Username"];
                    k.Password = (string)row["Password"];
                    //k.Obrisan = (bool)row["Obrisan"];
                    //cuvanje tipa u bazi
                    /*int tkId = (int)row["tipKorisnika"];
                    foreach (TipKorisnika tk in Podaci.Instance.TipoviKorisnika)
                    {
                        if (tk.tkId == tkId)
                            k.Tip_Korisnika = tk;
                    }
                    foreach (TipKorisnika tk in Podaci.Instance.TipoviKorisnika)
                    {
                        if (tk.tkId == tkId)
                            k.Tip_Korisnika = tk;
                    }*/
                    k.Obrisan = (bool)row["Obrisan"];
                    Podaci.Instance.KorisniciPodaci.Add(k);
                }

            }
         }
         
    }
}
