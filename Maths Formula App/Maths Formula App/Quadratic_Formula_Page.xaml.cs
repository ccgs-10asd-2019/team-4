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
    public partial class Quadratic_Formula_Page : Page
    {
        public Quadratic_Formula_Page()
        {
            InitializeComponent();
        }




        public static Tuple<double, double> SolveQuadratic(double a, double b, double c)
        {

            //There is no solution. 
            //if the re are no real solutions, but 2 complex solutions that i am not going to code. 
            //if the root is 0, then there is one solution, and if it bigger than zero then there are 2 solutions.
            double x1 = 0;
            double x2 = 0;

            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //Calculate the inside of the square root. 
            double insideSquareRoot = (b * b) - 4 * a * c;

            if (insideSquareRoot >= 0)
            {
                //Compute the value of each x. 
                //if there is only one solution, both x's will be the same. 
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b + sqrt) / (2 * a);
                x2 = (-b - sqrt) / (2 * a);
            }

            return Tuple.Create(x1, x2);

        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            Tuple<double, double> solution = SolveQuadratic(Convert.ToDouble(___inputBoxa__.Text), Convert.ToDouble(___inputBoxb__.Text), Convert.ToDouble(___inputBoxc__.Text));
            ___endProductBox_.Text = solution.ToString();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void help_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
