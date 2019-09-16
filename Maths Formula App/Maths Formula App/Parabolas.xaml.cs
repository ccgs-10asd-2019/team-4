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
using System.Timers;

namespace Maths_Formula_App
{
    /// <summary>
    /// Interaction logic for Parabolas.xaml
    /// </summary>
    public partial class Parabolas : Page
    {

        public Parabolas()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            ___theCanvas_.Children.Clear();
            
            double a = Convert.ToDouble(___inputBoxa__.Text);
            double b = Convert.ToDouble(___inputBoxh__.Text);
            double c = Convert.ToDouble(___inputBoxk__.Text);

            double origin_x = ___theCanvas_.Width / 2;
            double origin_y = ___theCanvas_.Height / 2;

            for (var i = 0; i <= 100; i += 1)
            {
                double y = (a * (i*i)) + (b * i) + c;

                

                Ellipse aCircle = new Ellipse();
                aCircle.Width = 10;
                aCircle.Height = 10;
                aCircle.Fill = new SolidColorBrush(Colors.Red);
                aCircle.Stroke = new SolidColorBrush(Colors.Red);



                Canvas.SetLeft(aCircle, origin_x + i);
                Canvas.SetTop(aCircle, origin_y - y/10);







                Ellipse anotherCircle = new Ellipse();
                anotherCircle.Width = 10;
                anotherCircle.Height = 10;
                anotherCircle.Fill = new SolidColorBrush(Colors.Red);
                anotherCircle.Stroke = new SolidColorBrush(Colors.Red);

                Canvas.SetLeft(anotherCircle, origin_x - i);//make this work
                Canvas.SetTop(anotherCircle, origin_y - y/10);

                ___theCanvas_.Children.Add(aCircle);
                ___theCanvas_.Children.Add(anotherCircle);

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

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("Exponentials_page.xaml", UriKind.Relative));
            ___theCanvas_.Children.Clear();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
