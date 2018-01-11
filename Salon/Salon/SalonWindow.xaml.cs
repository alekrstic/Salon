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
using Salon.MODEL;


namespace Salon
{
    /// <summary>
    /// Interaction logic for SalonWindow.xaml
    /// </summary>
    public partial class SalonWindow : Window
    {
        //ICollectionView pview;
        
        public SalonWindow()
        {
            InitializeComponent();

            //pview = CollectionViewSource.GetDefaultView(Podaci.Instance.PodaciOSalonu);

            //dgSalonPodaci.ItemsSource = pview;
            //dgSalonPodaci.IsSynchronizedWithCurrentItem = true;
           // dgSalonPodaci.DataContext = this;
            //dgSalonPodaci.SelectedIndex = 0;
        }

        private void dgSalonPodaci_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
