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
using System.IO;

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

            
            var text = File.ReadAllText("ParabolaInfo.txt");
            ___informationBox_.Text = text;
            

        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            var rColour = RandomColour();

            double constant1 = 0;
            double constant2 = 0;

            double output = 0;
            bool result = double.TryParse(___inputBoxa__.Text, out output);

            double output2 = 0;
            bool result2 = double.TryParse(___inputBoxh__.Text, out output2);

            double output3 = 0;
            bool result3 = double.TryParse(___inputBoxk__.Text, out output3);


            if (___inputBoxa__.Text == "" || result == false || result2 == false || result3 == false)
            {
                MessageBox.Show("Input something. ");
            }


            else if (___inputBoxh__.Text == "" || result == false || result2 == false || result3 == false)
            {
                MessageBox.Show("Input something. ");
            }

            else if (___inputBoxk__.Text == "" || result == false || result2 == false || result3 == false)
            {
                MessageBox.Show("Input something. ");
            }

            else
            {
                
            
                double a = Convert.ToDouble(___inputBoxa__.Text);
                double b = Convert.ToDouble(___inputBoxh__.Text);
                double c = Convert.ToDouble(___inputBoxk__.Text);

                double origin_x = ___theCanvas_.Width / 2;
                double origin_y = ___theCanvas_.Height / 2;

                

                //for (double w = -50; w <= 50; w += 0.01)
                //{
                //    for (double x = -50; x <= 50; x += 0.01)
                //    {
                //        if ((w + x <= b + 0.5 && w + x >= b - 0.5) && (w * x >= c - 0.5 && w * x <= c + 0.5))
                //        {
                //            constant1 = w;
                //            constant2 = x;
                //        }
                //    }
                //}//tried to make a thing ot factorise a quadratic equation, didn't work. 


                for (var i = 0; i <= 200; i += 1)
                {
                    //double y = -(i * constant1) * (i * constant2);

                    double y = (a * (i * i)) + (b * i) + c;


                    Ellipse aCircle = new Ellipse();
                    aCircle.Width = 5;
                    aCircle.Height = 5;
                    aCircle.Fill = new SolidColorBrush(rColour);
                    aCircle.Stroke = new SolidColorBrush(rColour);

                
                    Canvas.SetLeft(aCircle, origin_x + i);
                    Canvas.SetTop(aCircle, origin_y - y/10);

                
                    Ellipse anotherCircle = new Ellipse();
                    anotherCircle.Width = 5;
                    anotherCircle.Height = 5;
                    anotherCircle.Fill = new SolidColorBrush(rColour);
                    anotherCircle.Stroke = new SolidColorBrush(rColour);


                    Canvas.SetLeft(anotherCircle, origin_x - i);
                    Canvas.SetTop(anotherCircle, origin_y - y/10);

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
            StreamWriter File = new StreamWriter("ParabolaInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();

            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("Exponentials_page.xaml", UriKind.Relative));
            ___theCanvas_.Children.Clear();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            ___theCanvas_.Children.Clear();
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("C:\\User Program Files\\anything you want\\team-4\\Maths Formula App\\ParabolaInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();
        }

        
        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            var text = File.ReadAllText("ParabolaInfo.txt");
            ___informationBox_.Text = text;
        }
    }
}
