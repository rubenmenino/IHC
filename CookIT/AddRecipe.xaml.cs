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

        public System.Windows.Visibility Visibility { get; set; }
        public int i = 1;
        public event PropertyChangedEventHandler PropertyChanged;
        public AddRecipe()
        {
            InitializeComponent();
        }

        

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Label label = new Label();
            TextBox tb = new TextBox();
            tb.Name = "Ingredient" + i;
            tb.FontSize = 15;
            label.Margin = new Thickness(0, 20, 0, 0);
            label.FontSize = 15;
            label.FontWeight = FontWeights.Bold;
            label.Content = "Enter ingredient: ";
            someStack.Children.Add(label);
            someStack.Children.Add(tb);
            
            i++;
            
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {


            //if(RecipeName.Text == "")
            //{
            //  MessageBox.Show("Enter text", "Error", MessageBoxButton.OK);
            //}
            
            

        }







    }


}
