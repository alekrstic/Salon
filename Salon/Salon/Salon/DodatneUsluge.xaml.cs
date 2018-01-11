using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Salon
{
    /// <summary>
    /// Interaction logic for DodatneUsluge.xaml
    /// </summary>
    public partial class DodatneUsluge : Window
    {
        //private int v;
        ICollectionView ICView;
        public DodatneUsluge izabranaUsluga { get; set; }
        
        public DodatneUsluge()
        {
            InitializeComponent();
            ICView = CollectionViewSource.GetDefaultView(Projekat.Instance.DodatnaUsluga);
            //ICView.Filter = viewFilter;
            dgSpisak.IsSynchronizedWithCurrentItem = true;
            dgSpisak.DataContext = this;
            dgSpisak.ItemsSource = ICView;
            //this.v = v;
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            DodajDodatneUsluge ddu = new DodajDodatneUsluge();
            ddu.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
           // var izabranaUsluga = (Namestaj)dgSpisak.SelectedItem;
            //var uslugaProzor = new DodajDodatneUsluge(izabranaUsluga, DodajDodatneUsluge.Operacija);
            //uslugaProzor.ShowDialog();
        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgSpisak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
