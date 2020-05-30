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
using System.Data;
using System.Security.Cryptography;
using System.ComponentModel;

namespace CookIT
{
    /// <summary>
    /// Logika interakcji dla klasy AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page, INotifyPropertyChanged
    {

        public int i = 1;
        public event PropertyChangedEventHandler PropertyChanged;
        public AddRecipe()
        {
            InitializeComponent();
        }
        public string Cap(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }


        public void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Ingr1.Text == "" && Ingr2.Text == "" && Ingr3.Text == "" && Ingr4.Text == "" && Ingr5.Text == "")
            {
                MessageBox.Show("Input at least one ingredient", "Error", MessageBoxButton.OK);
            }
            else if(RecipeName.Text == "")
            {
                MessageBox.Show("Input a recipe name", "Error", MessageBoxButton.OK);

            }
            else
            {
                MessageBox.Show("Recipe has been added", "Recipe Added", MessageBoxButton.OK);

                string name = Cap(RecipeName.Text);
                string cat = "";
                List<string> ings = new List<string>();
                string desc = Description.Text;

                if (soup.IsChecked == true)
                {
                    cat = "Soup";
                }
                if (ms.IsChecked == true)
                {
                    cat = "Milkshake";
                }
                if (ff.IsChecked == true)
                {
                    cat = "Fast-Food";
                }
                if (drinks.IsChecked == true)
                {
                    cat = "Drinks";
                }
                if (ds.IsChecked == true)
                {
                    cat = "Dessert";
                }
                if (pasta.IsChecked == true)
                {
                    cat = "Pastas";
                }
                if (Ingr1.Text != "")
                {
                    ings.Add(Cap(Ingr1.Text));
                }
                if (Ingr2.Text != "")
                {
                    ings.Add(Cap(Ingr2.Text));

                }
                if (Ingr3.Text != "")
                {
                    ings.Add(Cap(Ingr3.Text));

                }
                if (Ingr4.Text != "")
                {
                    ings.Add(Cap(Ingr4.Text));
                }
                if (Ingr5.Text != "")
                {
                    ings.Add(Cap(Ingr5.Text));
                }


                recipe temp = new recipe(name, ings, cat, desc);
                Globals.receitas.Add(temp);
            }

            
        }

    }


}