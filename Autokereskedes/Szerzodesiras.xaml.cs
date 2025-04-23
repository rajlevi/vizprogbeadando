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
    /// Interaction logic for Szerzodesiras.xaml
    /// </summary>
    public partial class Szerzodesiras : Page
    {
        public Szerzodesiras()
        {
            InitializeComponent();
        }

        private void doneBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A dokumentum mentésre került!", "Save completed!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
