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

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (Ingr1.Text == "" && Ingr2.Text == "" && Ingr3.Text == "" && Ingr4.Text == "" && Ingr5.Text == "")
            {
                MessageBox.Show("Input at least one ingridient", "Error", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Recipe has been added", "Recipe Added", MessageBoxButton.OK);
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }


}