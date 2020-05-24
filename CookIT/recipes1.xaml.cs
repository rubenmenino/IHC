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
    /// Interaction logic for recipes1.xaml
    /// </summary>
    public partial class recipes1 : UserControl
    {
        public recipes1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            recipesdown xxx = new recipesdown();
            NavigationService.GetNavigationService(this).Navigate(xxx);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pizzaRecipe pizza = new pizzaRecipe();
            pizza.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            recipeEsquerdaLemonade qqq = new recipeEsquerdaLemonade();
            NavigationService.GetNavigationService(this).Navigate(qqq);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            sopaRecipe sopa = new sopaRecipe();
            sopa.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            sobremesaRecipe sobremesa = new sobremesaRecipe();
            sobremesa.Show();
        }
    }
}
