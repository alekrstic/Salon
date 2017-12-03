using System.Windows;
using Salon.MODEL;

namespace Salon.UI
{
    /// <summary>
    /// Interaction logic for Akcija.xaml
    /// </summary>
    public partial class Akcija : Window
    {
        public Akcija()
        {
            InitializeComponent();
           
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           DodajAkciju dakc = new DodajAkciju();
           dakc.ShowDialog();
        }

        private void DGPrikaz_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
