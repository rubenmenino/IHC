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
    /// Interaction logic for AddIngredient.xaml
    /// </summary>
    public partial class AddIngredient : UserControl
    {
        public AddIngredient()
        {
            InitializeComponent();
        }
        private void TextBox_GotFocus_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string txt = TextBox.Text;
            string cat = combo.Text;

            if (cat == "Dairy Products")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                dai.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
            if (cat == "Fruit")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                fru.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
            if (cat == "Vegetables")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                veg.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
        }
    }
}
