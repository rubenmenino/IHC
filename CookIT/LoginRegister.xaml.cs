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
    /// Interaction logic for LoginRegister.xaml
    /// </summary>
    public partial class LoginRegister : Page
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            user.Text = "";
        }

        private void pass_GotFocus_1(object sender, RoutedEventArgs e)
        {
            pass.Password = "";
        }

        private void goToRegistPage(object sender, RoutedEventArgs e)
        {
            Register nextPage = new Register();
            
        }
    }
}
