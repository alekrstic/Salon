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
    /// Interaction logic for Aplikacija.xaml
    /// </summary>
    public partial class Aplikacija : Window
    {
        public Aplikacija()
        {
            InitializeComponent();
            

        }
        


        private void btnPrikazNam_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kmdnam = new MainWindow();
            kmdnam.ShowDialog();
        }

        private void btnPrikazKor_Click(object sender, RoutedEventArgs e)
        {
            var korisnici = new UI.Korisnik();
            korisnici.ShowDialog();           // Korisnici kor = new Korisnici();
            //kor.ShowDialog();
            //Korisnik kor = new Korisnik();
            //kor.ShowDialog();

        }

        private void btnPrikazAkc_Click(object sender, RoutedEventArgs e)
        {
            var akcija = new UI.Akcija();
            akcija.ShowDialog();
        }

        private void btnProdaja_Click(object sender, RoutedEventArgs e)
        {
           
            var pronam = new UI.Prodaja();
            pronam.ShowDialog();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDodatneUsluge_Click(object sender, RoutedEventArgs e)
        {
            var du = new DodatneUsluge();
            du.ShowDialog();
        }

        private void btnsalon_Click(object sender, RoutedEventArgs e)
        {
            SalonWindow sw = new SalonWindow();
            sw.ShowDialog();
            
        }
    }
}
