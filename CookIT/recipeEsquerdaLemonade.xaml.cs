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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lemonadeRecipe lemo = new lemonadeRecipe();
            lemo.Show();
        }
    }
}
