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
        public class Auto
        {
            public string Marka { get; set; }
            public string Tipus { get; set; }
            public int Ar { get; set; }

            public override string ToString()
            {
                return $"{Marka} - {Tipus} - {Ar} Ft";
            }
        }

        List<Auto> autoLista = new List<Auto>
{
    new Auto { Marka = "Toyota", Tipus = "Corolla", Ar = 3000000 },
    new Auto { Marka = "BMW", Tipus = "320i", Ar = 4500000 },
    new Auto { Marka = "Audi", Tipus = "A4", Ar = 5000000 },
    new Auto { Marka = "Suzuki", Tipus = "Swift", Ar = 2000000 }
};
        public AutoLista()
        {
            InitializeComponent();
            ResultsListBox.ItemsSource = autoLista;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Az autók listájának inicializálása
            
        }

        private void keresesBtn_Click(object sender, RoutedEventArgs e)
        {
            string keresettSzoveg = SearchTextBox.Text.ToLower();
            List<Auto> talalatok = new List<Auto>();

            if (MarkaRadio.IsChecked == true)
            {
                talalatok = autoLista
                    .Where(a => a.Marka.ToLower().Contains(keresettSzoveg))
                    .ToList();
            }
            else if (TipusRadio.IsChecked == true)
            {
                talalatok = autoLista
                    .Where(a => a.Tipus.ToLower().Contains(keresettSzoveg))
                    .ToList();
            }
            else if (ArRadio.IsChecked == true)
            {
                if (int.TryParse(keresettSzoveg, out int keresettAr))
                {
                    talalatok = autoLista
                        .Where(a => a.Ar == keresettAr)
                        .ToList();
                }
                else
                {
                    MessageBox.Show("Kérlek számot adj meg az árhoz!", "Hibás bevitel", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Válassz ki egy keresési feltételt!", "Hiányzó választás", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (talalatok.Count == 0)
            {
                MessageBox.Show("Nem található adat a megadott mező alapján.", "Nincs találat", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

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

    

