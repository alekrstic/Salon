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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private Korisnik korisnik;
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var listaKor = Projekat.Instance.Korisnik;
            foreach (var k in listaKor)
            {
                if (tbKorIme.Text != k.Username || pbPass.Password != k.Password)
                {
                    MessageBox.Show("Unesi podatke ponovo", "ERROR", MessageBoxButton.OK);
                    return;

                }
                else if (tbKorIme.Text == k.Username && pbPass.Password == k.Password)
                {
                    var Aplikacija = new Aplikacija();
                    Aplikacija.ShowDialog();
                    this.Close();
                    return;
                }
                return;
            }
            return;
        }
    }

}
