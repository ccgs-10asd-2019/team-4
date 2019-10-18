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
    /// Interaction logic for IndecesSection.xaml
    /// </summary>
    public partial class IndecesSection : Page
    {
        public IndecesSection()
        {
            InitializeComponent();
        }

        private void Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("Indicies.xaml", UriKind.Relative));
        }

        private void Help_Button(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Return(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        private void Calculator(object sender, RoutedEventArgs e)
        {

        }
    }
}
