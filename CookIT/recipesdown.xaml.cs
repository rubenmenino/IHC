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
    /// Interaction logic for recipesdown.xaml
    /// </summary>
    public partial class recipesdown : UserControl
    {
        public recipesdown()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            recipes1 aaa = new recipes1();
            NavigationService.GetNavigationService(this).Navigate(aaa);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            recipeEsquerdaLemonade uuu = new recipeEsquerdaLemonade();
            NavigationService.GetNavigationService(this).Navigate(uuu);
        }
    }
}
