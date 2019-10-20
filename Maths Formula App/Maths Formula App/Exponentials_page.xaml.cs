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
    /// Interaction logic for Individual_formula_page_template.xaml
    /// </summary>
    public partial class Exponentials_page : Page
    {
        public EventHandler ladder;
        
        public Exponentials_page()
        {
            InitializeComponent();
        }

        private void Calculator(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Page1());
            this.Frame.Navigate(new Uri("Page1.xaml", UriKind.Relative));
        }


        private void Help_Button(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Help());
            this.Frame.Navigate(new Uri("Help.xaml", UriKind.Relative));
        }
        
        public void ClimbLadder()
        {

        }
        private void Home_Return(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new MainPage());
            this.Frame.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        }

        //private void CubicClick(object sender, RoutedEventArgs e)
        //{
        //    Frame.Navigate(new cubic());
        //    this.Frame.Navigate(new Uri("cubic.xaml", UriKind.Relative));
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new cubic());
            this.Frame.Navigate(new Uri("Parabolas.xaml", UriKind.Relative));
        }





        /* APPARENTLY SOLVES THE QUADRATIC EQUATION. 
        public static void SolveQuadratic(double a, double b, double c, out double x1, out double x2)
        {
            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //Calculate the inside of the square root
            double insideSquareRoot = (b * b) - 4 * a * c;

            if (insideSquareRoot < 0)
            {
                //There is no solution
                x1 = double.NaN;
                x2 = double.NaN;
            }
            else
            {
                //Compute the value of each x
                //if there is only one solution, both x's will be the same
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b + sqrt) / (2 * a);
                x2 = (-b - sqrt) / (2 * a);
            }
        }
        */


    }
}
