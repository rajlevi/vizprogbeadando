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
    /// Interaction logic for AutoLista.xaml
    /// </summary>
    public partial class AutoLista : Page
    {
        private List<string> autok = new List<string>
    {
        "Audi - A4 - 5000",
        "BMW - 320 - 6000",
        "Ford - Focus - 4000",
        "Audi - A3 - 4500",
        "Mercedes - C200 - 7000"
    };

        public AutoLista()
        {
            InitializeComponent();
      ResultsListBox.ItemsSource = autok;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Az autók listájának inicializálása
            ResultsListBox.ItemsSource = autok;
        }

        private void keresesBtn_Click(object sender, RoutedEventArgs e)
        {
            string keresettSzoveg = SearchTextBox.Text.ToLower();

     

            // Keresés: ha a szöveg bármelyik mezőben előfordul
            var talalatok = autok.Where(a => a.ToLower().Contains(keresettSzoveg)).ToList();

            // Listázás
            ResultsListBox.ItemsSource = talalatok;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

    

