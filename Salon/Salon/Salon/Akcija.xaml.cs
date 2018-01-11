using System.Windows;
using Salon.MODEL;
using System.ComponentModel;
using System.Windows.Data;

namespace Salon.UI
{
    /// <summary>
    /// Interaction logic for Akcija.xaml
    /// </summary>
    public partial class Akcija : Window
    {
        ICollectionView ICView;
        public Akcija izabranaAkcija { get; set; }
        public Akcija()
        {
            InitializeComponent();
            ICView = CollectionViewSource.GetDefaultView(Projekat.Instance.Akcija);
            DGPrikaz.IsSynchronizedWithCurrentItem = true;
            DGPrikaz.DataContext = this;
            DGPrikaz.ItemsSource = ICView;
            izabranaAkcija = DGPrikaz.SelectedItem as Akcija;
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
