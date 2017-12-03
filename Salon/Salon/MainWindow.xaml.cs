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

namespace Salon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 

     
        public MainWindow()
        {
            InitializeComponent();
            Prikaz();
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
            NamestajWindow nam = new NamestajWindow();
            nam.ShowDialog();
            //var NamestajProzor = new NamestajWindow(izaberi, NamestajWindow.Operacija.DODAJ);
            //NamestajProzor.ShowDialog();

            //Prikaz();
            //NamestajWindow namwindow = new NamestajWindow();
            //namwindow.ShowDialog();
            //Prikaz();
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            var izaberi = (MODEL.Namestaj)namestajListBox.SelectedItem;
            var NamestajProzor = new NamestajWindow(izaberi, NamestajWindow.Operacija.IZMENI);
            NamestajProzor.ShowDialog();

            Prikaz();


        }

        private void btnObrisi_Click(object sender, RoutedEventArgs e)
        {
            var izaberi = (MODEL.Namestaj)namestajListBox.SelectedItem;
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
                Prikaz();
            }
        }

        private void btnIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
