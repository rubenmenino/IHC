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

            // O ficheiro Globals.cs é onde definem variáveis e métodos Globais, os quais devem ser definidos como "public static"
            // Esta linha chama um método global
            Globals.InitListaReceitas();

            // Outra forma de adicionar receitas é adicionarem diretamente à variável global "receitas"
            // Para adicionar mais receitas à variável Global é utilizar o método Add.
            // Esta linha de código em baixo adiciona a receita "soup" à lista Global de receitas 
                    //Globals.receitas.Add(soup);

            //Este bloco de código lista todas as receitas da vossa variável Global com a lista de receitas
            for (int i = 0; i < Globals.receitas.Count(); i++)
            {
                Console.WriteLine(Globals.receitas[i].getName());
            }

           



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
            if (cat == "Meat and Fish")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                veg.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
            if (cat == "Others")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                ot.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
            if (cat == "Fruits & Vegetables")
            {
                var item = new ListBoxItem();
                item.Content = txt;
                item.Foreground = Brushes.White;
                fru.Items.Add(item);
                MessageBox.Show(txt + " added to category " + cat, "Success!");
            }
      
        }

        private void dai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = new ListBoxItem();
            temp = new ListBoxItem();
            temp.Content = (dai.SelectedItem.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
            temp.Foreground = Brushes.White;
            bool skip = false;
            foreach (var x in selGred.Items)
            {
                if (x.ToString().Replace("System.Windows.Controls.ListBoxItem:", "").Trim().Equals(temp.Content.ToString().Trim()))
                {
                    skip = true;
                }
            }
            if (!skip)
            {
                selGred.Items.Add(temp);
            }
        }


        private void fru_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = new ListBoxItem();
            temp = new ListBoxItem();
            temp.Content = (fru.SelectedItem.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
            temp.Foreground = Brushes.White;
            bool skip = false;
            foreach(var x in selGred.Items)
            {
                if (x.ToString().Replace("System.Windows.Controls.ListBoxItem:", "").Trim().Equals(temp.Content.ToString().Trim()))
                {
                    skip = true;
                }
            }
            if (!skip)
            {
                selGred.Items.Add(temp);
            }
        }

        private void veg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = new ListBoxItem();
            temp = new ListBoxItem();
            temp.Content = (veg.SelectedItem.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
            temp.Foreground = Brushes.White;
            bool skip = false;
            foreach (var x in selGred.Items)
            {
                if (x.ToString().Replace("System.Windows.Controls.ListBoxItem:", "").Trim().Equals(temp.Content.ToString().Trim()))
                {
                    skip = true;
                }
            }
            if (!skip)
            {
                selGred.Items.Add(temp);
            }

        }

        private void ot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = new ListBoxItem();
            temp = new ListBoxItem();
            temp.Content = (ot.SelectedItem.ToString().Replace("System.Windows.Controls.ListBoxItem:", ""));
            temp.Foreground = Brushes.White;
            bool skip = false;
            foreach (var x in selGred.Items)
            {
                if (x.ToString().Replace("System.Windows.Controls.ListBoxItem:", "").Trim().Equals(temp.Content.ToString().Trim()))
                {
                    skip = true;
                }
            }
            if (!skip)
            {
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            recipeListBox.Items.Clear();
            ListBoxItem temp = new ListBoxItem();
            List<String> listSelGred = new List<String>();
            bool toSkip;

            foreach (var item in selGred.Items)
            {
                listSelGred.Add(item.ToString().Replace("System.Windows.Controls.ListBoxItem:  ", ""));
            }
            

           foreach(recipe rec in Globals.receitas)
           { 
                toSkip = false;
                for(int i=1; i<rec.length(); i++)
                {
                    if (!listSelGred.Contains(rec.getIng().ElementAt(i)))
                    {
                        toSkip = true;
                    }
                }

                if (!recipeListBox.Items.Contains(rec.getIng().ElementAt(0)) && !toSkip)
                {
                    temp = new ListBoxItem();
                    temp.Content = (rec.getName());
                    temp.Foreground = Brushes.White;
                    recipeListBox.Items.Add(temp);
                }
           }
        }

    }
}
