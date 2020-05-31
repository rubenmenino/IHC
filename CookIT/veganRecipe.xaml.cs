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
    /// Interaction logic for veganRecipe.xaml
    /// </summary>
    public partial class veganRecipe : Window
    {
        public veganRecipe()
        {
            InitializeComponent();
        }

        private void customDesc1_Loaded(object sender, RoutedEventArgs e)
        {
            customDesc1.Text = Globals.customs.ElementAt(0).getDesc();

        }
    }
}
