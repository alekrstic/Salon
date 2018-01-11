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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Salon.MODEL;
using Salon.UI;
using System.ComponentModel;

namespace Salon.UI
{
    /// <summary>
    /// Interaction logic for Korisnik.xaml
    /// </summary>
    public partial class Korisnik : Window
    {
        ICollectionView ICView;

        public Korisnik IzabranKorisnik { get; set; }
        public Korisnik()
        {
            InitializeComponent();
            ICView = CollectionViewSource.GetDefaultView(Projekat.Instance.Korisnik);

            dgKorisnici.IsSynchronizedWithCurrentItem = true;
            dgKorisnici.DataContext = this;
            dgKorisnici.ItemsSource = ICView;

            IzabranKorisnik = dgKorisnici.SelectedItem as Korisnik;
            //Prikaz();
        }

        /*private void Prikaz()
        {
            lbKorisnici.Items.Clear();
            foreach(var korisnik in Projekat.Instance.Korisnik)
            {
                if (korisnik.Obrisan == false)
                {
                    lbKorisnici.Items.Add(korisnik);
                }
            }
        }
        */
        private void lbKorisnici_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void btnDodajKor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
