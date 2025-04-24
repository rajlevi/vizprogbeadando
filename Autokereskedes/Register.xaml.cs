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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public class User
        {
            public string Username { get; set; }
            public string JoinYear { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
        }

        List<User> regisztraltFelhasznalok = new List<User>();
        public Register()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string joinYear = JoinYearTextBox.Text;
            string phone = PhoneTextBox.Text;
            string password = PasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("A felhasználónév és jelszó kötelező!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var ujFelhasznalo = new User
            {
                Username = username,
                JoinYear = joinYear,
                PhoneNumber = phone,
                Password = password,
                Role = "admin"
            };

            regisztraltFelhasznalok.Add(ujFelhasznalo);

           
            MessageBoxResult result = MessageBox.Show("Sikeres regisztráció! Most jelentkezz be.", "Siker", MessageBoxButton.OK, MessageBoxImage.Information);

            if (result == MessageBoxResult.OK)
            {
                
                this.NavigationService.Navigate(new LoginPage());
            }
        }
    }
            
}
        
            
       
            
        
    

