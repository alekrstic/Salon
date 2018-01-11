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
        Window prethodni = null;
        //private Korisnik korisnik;
        public Login(Window prethodniProzor)
        {
            InitializeComponent();
            prethodni = prethodniProzor;
            //UcitajIzBaze();
            // AdminConfigs();
            // ProdavacConfigs();
            //AutoLogin();
        }
        public Login()
        {
            InitializeComponent();
            Podaci.Instance.UcitajIzBaze();
        }
        /*private void AutoLogin()
        {
            tbKorIme.Text = "pera";
            pbPass.Password = "123";
            Button_Click(null, null);
        }
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string username = tbKorIme.Text;
            string password = pbPass.Password;
            bool isLogin = false;
            if (!username.Equals("") && !password.Equals(""))
            {
                foreach (Korisnik logKorisnik in Podaci.Instance.KorisniciPodaci)
                {
                    if (username.Equals(logKorisnik.Username) && password.Equals(logKorisnik.Password))
                        {
                        Aplikacija ap = new Aplikacija();
                        ap.Show();
                        Close();
                        isLogin = true;
                    }
                }
                if (isLogin.Equals(false))
                {
                    MessageBox.Show("Ponovo unesite podatke", "Pokusajte ponovo!",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    MessageBox.Show("Uspesno ste ulogovani", "Welcome.",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }


            /*var listaKor = Projekat.Instance.Korisnik;
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
            return;*/
        }
        private void Window_Activated(object sender, EventArgs e)
        {
            if (prethodni != null)
                prethodni.Close();
        }
    }
}



