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

namespace CookIT
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginRegister reg = new LoginRegister();
            this.NavigationService.Navigate(reg);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Registere_Click(object sender, RoutedEventArgs e)
        {
           LoginRegister ina = new LoginRegister();
           this.NavigationService.Navigate(ina);
        }

   
    }
}
