using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Salon.MODEL;
using Salon.UI;

namespace Salon
{
    /// <summary>
    /// Interaction logic for NamestajWindow.xaml
    /// </summary>
    public partial class NamestajWindow : Window
    {
        public enum Operacija
        {
            DODAJ,
            IZMENI
        };
        private Namestaj namestaj;
        private Operacija operacija;
    
        public NamestajWindow(Namestaj namestaj, Operacija operacija)
        {
            InitializeComponent();
            Inicijalizuj(namestaj, operacija);
        }
        public NamestajWindow()
        {
            
        }
        private void Inicijalizuj(Namestaj namestaj, Operacija operacija)
        {
            this.namestaj = namestaj;
            this.operacija = operacija;

            this.tbNaziv.Text = namestaj.Naziv;
            this.tbSifra.Text = namestaj.Sifra;
            this.tbCena.Text = namestaj.Cena.ToString();
            foreach (var tipNamestaja in Projekat.Instance.TipNamestaja)
            {
                cbTipNamestaja.Items.Add(tipNamestaja);
            }
            foreach(TipNamestaja tipNamestaja in cbTipNamestaja.Items)
            {
                if (tipNamestaja.Id == namestaj.TipNamestajaId)
                {
                    cbTipNamestaja.SelectedItem = tipNamestaja;
                    break;
                }
            }
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnsacuvaj_Click(object sender, RoutedEventArgs e)
        {
            var listaNamestaja = Projekat.Instance.Namestaj;
            var izabraniTip = (TipNamestaja)cbTipNamestaja.SelectedItem;

            switch (operacija)
            {
                case Operacija.DODAJ:
                    var kCena = double.Parse(tbCena.Text);
                    var noviNamestaj = new Namestaj()
                    {
                        Id = listaNamestaja.Count + 1,
                        Naziv = this.tbNaziv.Text,
                        Sifra = this.tbSifra.Text,
                        Cena = kCena,

                        TipNamestajaId = izabraniTip.Id
                    };
                    listaNamestaja.Add(noviNamestaj);
                    break;

                case Operacija.IZMENI:
                    foreach (var n in listaNamestaja)
                    {
                        var kCena1 = double.Parse(tbCena.Text);
                        if (n.Id == namestaj.Id)
                        {
                            tbCena.Text = double.Parse(tbCena.Text).ToString();
                            n.Naziv = this.tbNaziv.Text;
                            n.Sifra = this.tbSifra.Text;
                            n.Cena = kCena1;
                            n.TipNamestajaId = izabraniTip.Id;
                            break;



                        }
                    }
                    break;
            }
                Projekat.Instance.Namestaj = listaNamestaja;
                this.Close();
                     }

        private void tbNaziv_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbSifra_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbCena_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbKolicina_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbTipNamestaja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
        }
    

