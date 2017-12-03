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
    /// Interaction logic for DodajDodatneUsluge.xaml
    /// </summary>
    public partial class DodajDodatneUsluge : Window
    {
        internal static object Operacija;
        private Namestaj izabranaUsluga;
        private object iZMENA;

        public DodajDodatneUsluge()
        {
            InitializeComponent();
        }

        public DodajDodatneUsluge(Namestaj izabranaUsluga, object iZMENA)
        {
            this.izabranaUsluga = izabranaUsluga;
            this.iZMENA = iZMENA;
        }

        private void txtCena_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
