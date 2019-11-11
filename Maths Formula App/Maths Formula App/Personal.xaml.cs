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
    /// Interaction logic for Personal.xaml
    /// </summary>
    public partial class Personal : Page
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Parabola_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Parabola_Notes());
            this.Frame.Navigate(new Uri("Parabola_Notes.xaml", UriKind.Relative));
        }

        private void Quadratic_Formula_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Quadratic_Formula_Notes());
            this.Frame.Navigate(new Uri("Quadratic_Formula_Notes.xaml", UriKind.Relative));
        }

        private void Logarithms_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Logarithms_Notes());
            this.Frame.Navigate(new Uri("Logarithms_Notes.xaml", UriKind.Relative));
        }

        private void Indices_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Help());
            this.Frame.Navigate(new Uri("Help.xaml", UriKind.Relative));
        }

        private void Home_Return(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new MainPage());
            this.Frame.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void Pythagoras_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pythag_Notes());
            this.Frame.Navigate(new Uri("Pythag_Notes.xaml", UriKind.Relative));
        }
    }
}
