using System.Windows;

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
    }
}
