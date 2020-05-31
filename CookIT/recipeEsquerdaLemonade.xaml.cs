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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (Globals.customs.Count == 1)
            {
                custom1.Visibility = Visibility.Visible;
                customCat1.Text = Globals.customs.ElementAt(0).getType();
                string x = "";
                foreach(string ing in Globals.customs.ElementAt(0).getIng())
                {
                    x += "- " + ing + "\n";

                }
                customIng1.Text = x;

            }

            if(Globals.customs.Count == 2)
            {
                custom1.Visibility = Visibility.Visible;
                customCat1.Text = Globals.customs.ElementAt(0).getType();
                string x = "";
                foreach (string ing in Globals.customs.ElementAt(0).getIng())
                {
                    x += "- " + ing + "\n";
                }
                customIng1.Text = x;


                custom2.Visibility = Visibility.Visible;
                customCat2.Text = Globals.customs.ElementAt(1).getType();
                string y = "";
                foreach (string ing in Globals.customs.ElementAt(1).getIng())
                {
                    y += "- " + ing + "\n";
                }
                customIng2.Text = x;
            }
        }
    }
}
