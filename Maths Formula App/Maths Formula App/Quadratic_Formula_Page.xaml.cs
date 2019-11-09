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
using System.IO;

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

            
            double x1 = 0;
            double x2 = 0;

             
            double insideSquareRoot = (b * b) - 4 * a * c;

            if (insideSquareRoot >= 0)
            {
                 
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b + sqrt) / (2 * a);
                x2 = (-b - sqrt) / (2 * a);
            }

            return Tuple.Create(x1, x2);

        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa__.Text == "")
            {
                MessageBox.Show("Input something. ");
            }


            else if (___inputBoxb__.Text == "")
            {
                MessageBox.Show("Input something. ");
            }

            else if (___inputBoxc__.Text == "")
            {
                MessageBox.Show("Input something. ");
            }

            else
            {
                Tuple<double, double> solution = SolveQuadratic(Convert.ToDouble(___inputBoxa__.Text), Convert.ToDouble(___inputBoxb__.Text), Convert.ToDouble(___inputBoxc__.Text));
                ___endProductBox_.Text = solution.ToString();
            }
        }
        
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Individual_formula_page_template());
            this.Frame.Navigate(new Uri("Individual_formula_page_template.xaml", UriKind.Relative));
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            var text = File.ReadAllText("QuadraticInfo.txt");
            ___informationBox_.Text = text;
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("C:QuadraticInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();
        }
    }
}
