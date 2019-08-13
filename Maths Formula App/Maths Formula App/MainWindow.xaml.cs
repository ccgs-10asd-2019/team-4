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

namespace Maths_Formula_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Trig_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Individual_formula_page_template());
            this.Frame.Navigate(new Uri("Individual_formula_page_template.xaml", UriKind.Relative));
        }

        private void Expo_Click(object sender, RoutedEventArgs e)
        {
     
        }

        private void Geo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Personal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
