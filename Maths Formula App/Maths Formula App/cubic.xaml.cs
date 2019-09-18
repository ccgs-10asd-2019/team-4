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
    /// Interaction logic for cubic.xaml
    /// </summary>
    public partial class cubic : Page
    {
        public cubic()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            var rColour = RandomColour();



            if (___inputBoxa__.Text == "")
            {
                MessageBox.Show("Enter value for a. ");
            }


            else if (___inputBoxh__.Text == "")
            {
                MessageBox.Show("Enter value for b. ");
            }

            else if (___inputBoxk__.Text == "")
            {
                MessageBox.Show("Enter value for c. ");
            }

            else if (___inputBoxd__.Text == "")
            {
                MessageBox.Show("Enter value for d. ");
            }

            else
            {
                double a = Convert.ToDouble(___inputBoxa__.Text);
                double b = Convert.ToDouble(___inputBoxh__.Text);
                double c = Convert.ToDouble(___inputBoxk__.Text);
                double d = Convert.ToDouble(___inputBoxd__.Text);

                double origin_x = ___theCanvas_.Width / 2;
                double origin_y = ___theCanvas_.Height / 2;

                

                for (var i = 0; i <= 100; i += 1)
                {
                    double y = (a * (i * i * i)) + (b * i * i) + (c * i) + d;



                    Ellipse aCircle = new Ellipse();
                    aCircle.Width = 10;
                    aCircle.Height = 10;
                    aCircle.Fill = new SolidColorBrush(rColour);
                    aCircle.Stroke = new SolidColorBrush(rColour);


                    Canvas.SetLeft(aCircle, origin_x + i);
                    Canvas.SetTop(aCircle, origin_y - y / 10);


                    Ellipse anotherCircle = new Ellipse();
                    anotherCircle.Width = 10;
                    anotherCircle.Height = 10;
                    anotherCircle.Fill = new SolidColorBrush(rColour);
                    anotherCircle.Stroke = new SolidColorBrush(rColour);


                    Canvas.SetLeft(anotherCircle, origin_x - i);
                    Canvas.SetTop(anotherCircle, origin_y - y / 10);

                    ___theCanvas_.Children.Add(aCircle);
                    ___theCanvas_.Children.Add(anotherCircle);

                }
            }

            
        }


        private void circle(double x, double y)
        {
            Ellipse aCircle = new Ellipse();
            aCircle.Width = 10;
            aCircle.Height = 10;
            aCircle.Fill = new SolidColorBrush(Colors.Red);
            aCircle.Stroke = new SolidColorBrush(Colors.Red);

        }


        public Color RandomColour()
        {

            Random rand = new Random();
            int max = byte.MaxValue + 1;
            byte r = Convert.ToByte(rand.Next(max));
            byte g = Convert.ToByte(rand.Next(max));
            byte b = Convert.ToByte(rand.Next(max));

            Color c = Color.FromRgb(r, g, b);

            return c;
            
        }


        private void back_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(new Exponentials_page());
            //this.Frame.Navigate(new Uri("Exponentials_page.xaml", UriKind.Relative));
            //___theCanvas_.Children.Clear();
        }


        private void help_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Clear(object sender, RoutedEventArgs e)
        {
            ___theCanvas_.Children.Clear();
        }
    }
}
