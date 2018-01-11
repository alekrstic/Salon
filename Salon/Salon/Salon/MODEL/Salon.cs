using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace Salon.MODEL
{
    [Serializable]
    /* public class Salon : INotifyPropertyChanged
     {
         public event PropertyChangedEventHandler PropertyChanged;
         private int Id;
         private string Naziv;
         private string Adresa;
         private int Telefon;
         private string Email;
         private string Sajt_adresa;
         private int Pib;
         private int Maticni_broj;
         private string Ziro_racun;

         public int ID
         {
             get { return Id; }
             set { Id = value; OnPropertyChanged("ID"); }

         }
         public string NAZIV
         {
             get { return Naziv; }
             set { Naziv = value; OnPropertyChanged("NAZIV"); }
         }
         public string ADRESA
         {
             get { return Adresa; }
             set { Adresa = value; OnPropertyChanged("ADRESA"); }
         }
         public int TELEFON
         {
             get { return Telefon; }
             set { Telefon = value; OnPropertyChanged("TELEFON"); }
         }
         public string EMAIL
         {
             get { return Email; }
             set { Email = value; OnPropertyChanged("EMAIL"); }
         }
         public string SAJT_ADRESA
         {
             get { return Sajt_adresa; }
             set { Sajt_adresa = value; OnPropertyChanged("SAJT_ADRESA"); }
         }
         public int PIB
         {
             get { return Pib; }
             set { Pib = value; OnPropertyChanged("PIB"); }
         }
         public int MATICNI_BROJ
         {
             get { return Maticni_broj; }
             set { Maticni_broj = value; OnPropertyChanged("MATICNI_BROJ"); }
         }
         public string ZIRO_RACUN
         {
             get { return Ziro_racun; }
             set { Ziro_racun = value; OnPropertyChanged("ZIRO_RACUN"); }
         }






         protected void OnPropertyChanged(string propertyName)
         {
             if (PropertyChanged != null)
             {
                 PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
             }
         }

         public override string ToString()
         {
             return Naziv + ", " + Adresa + ", " + PIB;
         }



     }





     */
    public class Salon
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

        public static ObservableCollection<Salon> UcitajPodatke()
        {
            var lista = new ObservableCollection<Salon>();
            using (SqlConnection connection = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand podaci = connection.CreateCommand();
                podaci.CommandText = @"SELECT * FROM SALON";
                SqlDataAdapter dapodaci = new SqlDataAdapter();
                dapodaci.SelectCommand = podaci;
                dapodaci.Fill(ds, "SALON");

                foreach (DataRow row in ds.Tables["Salon"].Rows)
                {
                    Salon sal = new Salon();
                    sal.Id = (int)row["Id"];
                    sal.Naziv = (string)row["Naziv"];
                    sal.Adresa = (string)row["Adresa"];
                    sal.Telefon = (string)row["Telefon"];
                    sal.Email = (string)row["Email"];
                    sal.Sajt_adresa = (string)row["Sajt_adresa"];
                    sal.PIB = (int)row["PIB"];
                    sal.Maticni_broj = (int)row["Maticni_broj"];
                    sal.Ziro_racun = (string)row["Ziro_racun"];

                    sal.Obrisan = (bool)row["Obrisan"];
                    lista.Add(sal);
                }
            }
            return lista;
        }
    }
}

