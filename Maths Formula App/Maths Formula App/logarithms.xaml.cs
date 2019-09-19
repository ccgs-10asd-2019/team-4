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
    /// Interaction logic for logarithms.xaml
    /// </summary>
    public partial class logarithms : Page
    {
        public logarithms()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(___inputBoxa__.Text);
            double b = Convert.ToDouble(___inputBoxb__.Text);

            double power = Math.Log(b, a);

            ___endProductBox_.Text = Convert.ToString(power);

        }

        private void backClick(object sender, RoutedEventArgs e)
        {

        }

        private void helpClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
