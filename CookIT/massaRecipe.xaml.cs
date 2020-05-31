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
using System.Windows.Shapes;

namespace CookIT
{
    /// <summary>
    /// Interaction logic for massaRecipe.xaml
    /// </summary>
    public partial class massaRecipe : Window
    {
        public massaRecipe()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            customDesc2.Text = Globals.customs.ElementAt(1).getDesc();
        }
    }
}
