using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.MODEL
{
    [Serializable]
    public class DodatnaUsluga
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public double Cena { get; set; }
        public bool Obrisan { get; set; }

        public static ObservableCollection<DodatnaUsluga> UcitajUsluge()
        {
            var listaUsluga = new ObservableCollection<DodatnaUsluga>();
            using (SqlConnection connection = new SqlConnection(Podaci.CONNECTION_STRING))
            {
                connection.Open();
                 DataSet ds = new DataSet();
                SqlCommand uslugacmd = connection.CreateCommand();
                uslugacmd.CommandText = @"SELECT * FROM USLUGA";
                SqlDataAdapter dausluga = new SqlDataAdapter();
                dausluga.SelectCommand = uslugacmd;
                dausluga.Fill(ds, "USLUGA");

                foreach(DataRow row in ds.Tables["Usluga"].Rows)
                {
                    DodatnaUsluga dodusl = new DodatnaUsluga();
                    dodusl.Id = (int)row["Id"];
                    dodusl.Naziv = (string)row["Naziv"];
                    dodusl.Cena = (int)row["Cena"];
                    dodusl.Obrisan = (bool)row["Obrisan"];
                    listaUsluga.Add(dodusl);
                }

            }
            return listaUsluga;
        }
    }

}
