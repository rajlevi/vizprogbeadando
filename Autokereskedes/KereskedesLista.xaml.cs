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
    /// Interaction logic for KereskedesLista.xaml
    /// </summary>
    public partial class KereskedesLista : Page
    {
        private List<string> kereskedesek = new List<string>
    {
        "Karcsi Autóház - Budapest",
        "MaxiCar - Debrecen",
        "AutoPlaza - Győr",
        "CityAutó - Szeged",
        "LuxCar - Budapest"
    };

        public KereskedesLista()
        {
            InitializeComponent();
            ResultsListBox.ItemsSource = kereskedesek;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void keresesBtn_Click(object sender, RoutedEventArgs e)
        {
            string keresettSzoveg = SearchTextBox.Text.ToLower();

            // Ha üres a kereső, mutasson mindent
            if (string.IsNullOrWhiteSpace(keresettSzoveg))
            {
                ResultsListBox.ItemsSource = kereskedesek;
                return;
            }

            List<string> talalatok = new List<string>();

            foreach (var item in kereskedesek)
            {
                var reszek = item.Split('-');
                if (reszek.Length >= 2)
                {
                    string kereskedoNev = reszek[0].Trim().ToLower();
                    string varos = reszek[1].Trim().ToLower();

                    if (RadioKereskedes.IsChecked == true && kereskedoNev.Contains(keresettSzoveg))
                    {
                        talalatok.Add(item);
                    }
                    else if (RadioVaros.IsChecked == true && varos.Contains(keresettSzoveg))
                    {
                        talalatok.Add(item);
                    }
                }
            }

            ResultsListBox.ItemsSource = talalatok;

        }
    }
}
