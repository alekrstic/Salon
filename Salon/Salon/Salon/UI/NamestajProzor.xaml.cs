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

namespace Salon.UI
{
    /// <summary>
    /// Interaction logic for NamestajProzor.xaml
    /// </summary>
    public partial class NamestajProzor : Window
    {
        public enum Operacija { DODAVANJE, IZMENA};
        private Namestaj namestaj;
        private Operacija operacija;
        public NamestajProzor(Namestaj namestaj, Operacija operacija)
        {
            InitializeComponent();
            this.namestaj = namestaj;
            this.operacija = operacija;

            cbTip.ItemsSource = Projekat.Instance.TipNamestaja;
            tbNaziv.DataContext = namestaj;
            tbSifra.DataContext = namestaj;
            tbCena.DataContext = namestaj;
            tbKolicina.DataContext = namestaj;
            cbTip.DataContext = namestaj;
        }
        public NamestajProzor()
        {
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSAVE_Click(object sender, RoutedEventArgs e)
        {
           // var lista = Projekat.Instance.Namestaj;
            //var izabranitipNamestaja = (TipNamestaja)cbTip.SelectedItem;
            //switch (operacija)
            //{
              //  case Operacija.DODAVANJE:
                //    namestaj.Id = lista.Count + 1;
                  //  Namestaj.Create(namestaj);
                    //break;

                    //case Operacija.IZMENA:
                   // break;
                    
            }
         //   this.Close();
        }
    }
//}
