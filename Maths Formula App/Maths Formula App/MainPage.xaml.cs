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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Alg_Click(object sender, RoutedEventArgs e)
        {
            ShowAlgebra();
        }
        private void ShowAlgebra()
        {
            Frame.Navigate(new Individual_formula_page_template());
            this.Frame.Navigate(new Uri("Individual_formula_page_template.xaml", UriKind.Relative));
        }

        private void Expo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("Exponentials_page.xaml", UriKind.Relative));
        }

        private void Geo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new geometry());
            this.Frame.Navigate(new Uri("geometry.xaml", UriKind.Relative));
        }

        private void Personal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("IndecesSection.xaml", UriKind.Relative));
        }
    }
}
