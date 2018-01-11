using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Salon.MODEL;
namespace Salon.MODEL

{
    //[Serializable]
    public class TipKorisnika
    {
        public int tkId { get; set; }
        public string Naziv { get; set; }

        public bool Obrisan { get; set; }

        public static void UcitajTipKorisnika()
        {
            using(SqlConnection konekcija = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                konekcija.Open();
                DataSet ds = new DataSet();
                SqlCommand tipkorkomand = konekcija.CreateCommand();
                tipkorkomand.CommandText = @"SELECT * FROM TIPKORISNIKA";
                SqlDataAdapter datipk = new SqlDataAdapter();
                datipk.SelectCommand = tipkorkomand;
                datipk.Fill(ds, "TipKorisnika");

                foreach(DataRow row in ds.Tables["TipKorisnika"].Rows)
                {
                    TipKorisnika tipk = new TipKorisnika();
                    tipk.tkId = (int)row["TkId"];
                    tipk.Naziv = (string)row["Naziv"];
                    tipk.Obrisan = (bool)row["Obrisan"];

                    Podaci.Instance.TipoviKorisnika.Add(tipk);
                }
            }
            }
        public static void DodajTipKorisnika(TipKorisnika nk)
        {
            using(SqlConnection conn = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO TIPKORISNIKA (NAZIV, OBRISAN) VALUES(@NAZIV, @OBRISAN)";
                command.Parameters.Add(new SqlParameter("@Naziv", nk.Naziv));
                command.Parameters.Add(new SqlParameter("@Obrisan", nk.Obrisan));
            }
        }
        public static void ObrisiTipKorisnika(TipKorisnika kn)
        {
            using(SqlConnection conn = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                if(kn.tkId !=0) //ako postoji u bazi
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = @"DELETE FROM TIPKORISNIKA WHERE TKID=@tkId";
                    command.Parameters.Add(new SqlParameter("@tkId", kn.tkId));
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void IzmeniTipKorisnika(TipKorisnika kn)
        {
            using (SqlConnection conn = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                if (kn.tkId != 0)//ako postoji u bazi
                {
                    conn.Open();

                    SqlCommand command = conn.CreateCommand();
                    command.CommandText = @"UPDATE TIPKORISNIKA SET Naziv=@Naziv, Obrisan=@Obrisan WHERE TKID=@tkId";
                    command.Parameters.Add(new SqlParameter("@tkId", kn.tkId));
                    command.Parameters.Add(new SqlParameter("@Naziv", kn.Naziv));
                    command.Parameters.Add(new SqlParameter("@Obrisan", kn.Obrisan));

                    command.ExecuteNonQuery();
                }
            }
        }
    }
       /* public TipKorisnika(int tkId, string Naziv, bool Obrisan)
        {
            this.tkId = tkId;
            this.Naziv = Naziv;
            this.Obrisan = Obrisan;
        }


        public override string ToString()
        {
            return Naziv;
        }
        public TipKorisnika()
        {

        }*/
    }

