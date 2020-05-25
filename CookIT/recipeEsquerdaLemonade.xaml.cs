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
    /// Interaction logic for recipeEsquerdaLemonade.xaml
    /// </summary>
    public partial class recipeEsquerdaLemonade : UserControl
    {
        public recipeEsquerdaLemonade()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            recipes1 ttt = new recipes1();
            NavigationService.GetNavigationService(this).Navigate(ttt);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Hidden1.Visibility == Visibility.Visible)
            {
                Hidden1.Visibility = Visibility.Hidden;
                Hidden2.Visibility = Visibility.Hidden;
            }
            else
            {
                Hidden1.Visibility = Visibility.Visible;
                Hidden2.Visibility = Visibility.Visible;
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            lemonadeRecipe qqqqqqqqqqq = new lemonadeRecipe();
            qqqqqqqqqqq.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            veganRecipe ppp = new veganRecipe();
            ppp.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            massaRecipe massa = new massaRecipe();
            massa.Show();
        }
    }
}
