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
using System.ComponentModel;
using Salon.MODEL;
using Salon.UI;

namespace Salon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICollectionView view;
        public Namestaj selektovani { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
            //Prikaz();
            //Podaci.Instance.UcitajIzBaze();

            view = CollectionViewSource.GetDefaultView(Podaci.Instance.Namestaj);
            //view.Filter = viewFilter;
            dg_namestaj.ItemsSource = view;
            dg_namestaj.IsSynchronizedWithCurrentItem = true;
            dg_namestaj.DataContext = this;
            dg_namestaj.SelectedIndex = 0;
            /*
            DataGridTextColumn col1 = new DataGridTextColumn();
            col1.Header = "Naziv";
            col1.Binding = new Binding("Naziv");
            dg_namestaj.Columns.Add(col1);
            DataGridTextColumn col2 = new DataGridTextColumn();
            col2.Header = "Cena";
            col2.Binding = new Binding("Cena");
            dg_namestaj.Columns.Add(col2);
            DataGridTextColumn col3 = new DataGridTextColumn();
            col3.Header = "Sifra";
            col3.Binding = new Binding("Sifra");
            dg_namestaj.Columns.Add(col3);
            DataGridTextColumn col4 = new DataGridTextColumn();
            col4.Header = "Kolicina";
            col4.Binding = new Binding("Kolicina");
            dg_namestaj.Columns.Add(col4);

            dg_namestaj.ItemsSource = view;
            dg_namestaj.IsSynchronizedWithCurrentItem = true;
            DataGridTextColumn col5 = new DataGridTextColumn();
            col5.Header = "Obrisan";
            col5.Binding = new Binding("Obrisan");
            dg_namestaj.Columns.Add(col5);
            DataGridTextColumn col6 = new DataGridTextColumn();
            col6.Header = "AkcijaId";
            col6.Binding = new Binding("AkcijaId");
            dg_namestaj.Columns.Add(col6);
            */

        }
        private void Prikaz()
        {
            namestajListBox.Items.Clear();
            foreach(var namestaj in Projekat.Instance.Namestaj)
            {
                if (namestaj.Obrisan == false)
                {
                    namestajListBox.Items.Add(namestaj);

                }
            }
        }
        
        private void namestajListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nam = new UI.NamestajProzor();
            nam.ShowDialog();
            
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            var izaberi = (MODEL.Namestaj)namestajListBox.SelectedItem;
            var NamestajProzor = new NamestajWindow(izaberi, NamestajWindow.Operacija.IZMENI);
            NamestajProzor.ShowDialog();

            //Prikaz();


        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {
           /* var izaberi = (MODEL.Namestaj)namestajListBox.SelectedItem;
            var listaNamestaja = Projekat.Instance.Namestaj;
            if (MessageBox.Show($"Zelite li da obrisete izabrano :{izaberi.Naziv}", "Brisanje", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                foreach (var nam in listaNamestaja)
                {
                    if (nam.Id == izaberi.Id)
                    {
                        nam.Obrisan = true;
                    }
                }
                Projekat.Instance.Namestaj = listaNamestaja;
               // Prikaz();
            }*/
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dg_namestaj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
