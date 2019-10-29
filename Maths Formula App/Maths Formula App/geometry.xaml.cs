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
    /// Interaction logic for geometry.xaml
    /// </summary>
    public partial class geometry : Page
    {
        public geometry()
        {
            InitializeComponent();
        }

        private void Quadratic_Formula_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Quadratic_Formula_Page());
            this.Frame.Navigate(new Uri("Quadratic_Formula_Page.xaml", UriKind.Relative));
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

        private void New_Calc(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Algebracalc());
            this.Frame.Navigate(new Uri("Algebracalc.xaml", UriKind.Relative));
        }

        private void SCTclick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new SinCosTan());
            this.Frame.Navigate(new Uri("SinCosTan.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Pythag());
            this.Frame.Navigate(new Uri("Pythag.xaml", UriKind.Relative));
        }
    }
}
