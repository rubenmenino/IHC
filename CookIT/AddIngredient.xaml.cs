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
        List<string> daiList = new List<string>();
        List<string> fruList = new List<string>();
        List<string> vegList = new List<string>();

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

        private void dai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            daiList = new List<string>();
            var temp = new ListBoxItem();
            foreach (var item in dai.SelectedItems)
            {
                daiList.Add(item.ToString());
            }

            foreach (var item in daiList)
            {
                temp = new ListBoxItem();
                temp.Content = (item.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
                temp.Foreground = Brushes.White;
                selGred.Items.Add(temp);
            }
        }


        private void fru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fruList = new List<string>();
            var temp = new ListBoxItem();
            foreach (var item in fru.SelectedItems)
            {
                fruList.Add(item.ToString());
            }

            foreach (var item in fruList)
            {
                temp = new ListBoxItem();
                temp.Content = (item.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
                temp.Foreground = Brushes.White;
                selGred.Items.Add(temp);
            }
        }

        private void veg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vegList = new List<string>();
            var temp = new ListBoxItem();
            foreach (var item in veg.SelectedItems)
            {
                vegList.Add(item.ToString());
            }

            foreach(var item in vegList)
            {
                temp = new ListBoxItem();
                temp.Content = (item.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
                temp.Foreground = Brushes.White;
                selGred.Items.Add(temp);
            }
            
        }

        private void selGred_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<object> toRemove = new List<object>();
            for(int i = selGred.Items.Count-1; i != -1; i--)
            {
                if (selGred.SelectedItems.Contains(selGred.Items.GetItemAt(i)))
                {
                    toRemove.Add(selGred.Items.GetItemAt(i));
                    selGred.Items.RemoveAt(i);
                }
            }

            foreach(var item in toRemove)
            {
                if (veg.SelectedItems.Contains(item))
                {
                    veg.SelectedItems.Remove(item);
                }
                if (dai.SelectedItems.Contains(item))
                {
                    dai.SelectedItems.Remove(item);
                }
                if (fru.SelectedItems.Contains(item))
                {
                    fru.SelectedItems.Remove(item);
                }
            }


        }

        private void teste_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            List<string> vegList = new List<string>()
            { "cherry", "butter", "bread"};

            List<string> recipes = new List<string>()
            { "steak", "Butterbread", "Cherrycake", "aqui mete--se as receitas supostamente, nao sei, só que vai dar a receita toda xdd e nao o nome , hmm :x :("};

            List<string> matchedRecipes = recipes.Where(x => vegList
                                                 .Any(s => x.ToLower().Contains(s.ToLower())))
                                                 .ToList();

            foreach (string i in matchedRecipes)
            {
                MessageBox.Show(i);
            }





            //List<string> recipes = new List<string>()
            //{ "steak", "Butterbread", "Cherrycake"};

            //List<string> matchedRecipes = recipes.Where(x => selGredList
            //                                     .Any(s => x.ToLower().Contains(s.ToLower())))
            //                                     .ToList();

            //teste.ItemsSource = matchedRecipes;

            //var temp = new ListBoxItem();
            //foreach (var item in teste.SelectedItems)
            //{
            //    daiList.Add(item.ToString());
            //}

            //foreach (var item in selGredList)
            //{
            //    temp = new ListBoxItem();
            //    temp.Content = (item.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
            //    temp.Foreground = Brushes.White;
            //    selGred.Items.Add(temp);
            //}
        }
    }
}
