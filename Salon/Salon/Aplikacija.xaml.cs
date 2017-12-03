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
;           Korisnik kor = new Korisnik();
            //kor.ShowDialog();

        }

        private void btnPrikazAkc_Click(object sender, RoutedEventArgs e)
        {
            Akcija akc = new Akcija();
            //akc.ShowDialog();
        }

        private void btnProdaja_Click(object sender, RoutedEventArgs e)
        {
            Namestaj radsanam = new Namestaj();
            //radsanam.ShowDialog();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
