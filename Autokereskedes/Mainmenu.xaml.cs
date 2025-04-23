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

namespace Autokereskedes
{
    /// <summary>
    /// Interaction logic for Mainmenu.xaml
    /// </summary>
    public partial class Mainmenu : Page
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void autokBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutoLista());
        }

        private void kereskedesekBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KereskedesLista());
        }

        private void szerzodesBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Szerzodesiras());
           /* bool admin = false;
            if (admin == true)
            {
                NavigationService.Navigate(new Szerzodesiras());
            }
            else
            {
                MessageBox.Show("Nincs jogosultsagod!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
