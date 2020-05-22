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

namespace CookIT
{
    /// <summary>
    /// Logika interakcji dla klasy AddRecipe.xaml
    /// </summary>
    public partial class AddRecipe : Page
    {
        
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextBox dynamicTextBox = new TextBox();
            dynamicTextBox.Text = "Type Partnumber";
            Grid.SetRow(dynamicTextBox, 1);
            Grid.SetColumn(dynamicTextBox, 0);
            //this.MainGrid.Children.Add(dynamicTextBox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Label label = new Label();
            TextBox tb = new TextBox();
            tb.Name = "RecipeName";
            tb.FontSize = 15;
            label.Margin = new Thickness(0, 20, 0, 0);
            label.FontSize = 15;
            label.FontWeight = FontWeights.Bold;
            label.Content = "Enter ingredient: ";
            someStack.Children.Add(label);
            someStack.Children.Add(tb);
            
        }

        
    }


}
