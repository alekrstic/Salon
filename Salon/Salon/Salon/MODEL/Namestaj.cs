using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

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
        public TipNamestaja tipn { get; set; }

        public static ObservableCollection<Namestaj> UcitajNamestaj()
        {  
            var lista = new ObservableCollection<Namestaj>();
            using (SqlConnection connection = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand namestajcommand = connection.CreateCommand();
                namestajcommand.CommandText = @"SELECT * FROM NAMESTAJ";
                SqlDataAdapter daNamestaj = new SqlDataAdapter();
                daNamestaj.SelectCommand = namestajcommand;
                daNamestaj.Fill(ds, "NAMESTAJ");

                foreach (DataRow row in ds.Tables["Namestaj"].Rows)
                {
                    Namestaj nam = new Namestaj();
                    nam.Id = (int)row["id"];
                    nam.Naziv = (string)row["naziv"];
                    nam.Sifra = (string)row["sifra"];
                    nam.Kolicina = (int)row["kolicina"];
                   // int Id = (int)row["Id"];
                    /*foreach (TipNamestaja tn in Podaci.Instance.TipoviNamestaja)
                    {
                        if (tn.Id == Id)
                            nam.tipn = tn;
                    }
                    foreach (TipNamestaja tn in Podaci.Instance.TipoviNamestaja)
                    {
                        if (tn.Id == Id)
                            nam.tipn = tn;
                    }
                    */
                    nam.Obrisan = (bool)row["obrisan"];

                    lista.Add(nam);
                }
                
            }
            return lista;
        }
        public static Namestaj Create(Namestaj cn)
        {
            using (SqlConnection connection = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                connection.Open();

                SqlCommand cnamestajcommand = connection.CreateCommand();
                cnamestajcommand.CommandText = "INSERT INTO NAMESTAJ(Naziv, Sifra, Kolicina, Obrisan) VALUES(@Naziv, @Sifra, @Kolicina, @Obrisan)";
                cnamestajcommand.CommandText += "SELECT SCOPE_IDENTITY();";
                cnamestajcommand.Parameters.AddWithValue("Naziv", cn.Naziv);
                cnamestajcommand.Parameters.AddWithValue("Sifra", cn.Sifra);
                cnamestajcommand.Parameters.AddWithValue("Kolicina", cn.Kolicina);
                cnamestajcommand.Parameters.AddWithValue("Obrisan", cn.Obrisan);
                

            }
            Projekat.Instance.Namestaj.Add(cn);
            return cn;
        }
        /*    public override string ToString()
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
            }*/

        public bool Obrisan { get; set; }

        public Akcija Akcija { get; set; }

        

        
        

        

    }
}
