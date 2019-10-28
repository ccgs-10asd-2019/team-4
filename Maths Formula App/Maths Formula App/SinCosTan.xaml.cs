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
    /// Interaction logic for SinCosTan.xaml
    /// </summary>
    public partial class SinCosTan : Page
    {
        public SinCosTan()
        {
            InitializeComponent();
        }

        

        

    private void backClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new geometry());
            this.Frame.Navigate(new Uri("geometry.xaml", UriKind.Relative));
        }

        private void helpClick(object sender, RoutedEventArgs e)
        {
            
            Frame.Navigate(new Help());
            this.Frame.Navigate(new Uri("Help.xaml", UriKind.Relative));
            
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("SinCosTanInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();
        }

        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            ___informationBox_.Text = File.ReadAllText("SinCosTanInfo.txt");
        }


        private void Sine(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa__.Text == "")
            {
                MessageBox.Show("Enter value for opposite side to angle. ");
            }


            else if (___inputBoxb__.Text == "")
            {
                MessageBox.Show("Enter value for hypotenuse. ");
            }

            else
            {
                double x = Convert.ToDouble(___inputBoxa__.Text) / Convert.ToDouble(___inputBoxb__.Text);
                ___endProductBox_.Text = Convert.ToString(Math.Sin(Math.PI / 180 * x));
            }
        }

        

        private void CosButton(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa___Copy.Text == "")
            {
                MessageBox.Show("Enter value for adjacent. ");
            }


            else if (___inputBoxb___Copy.Text == "")
            {
                MessageBox.Show("Enter value for hypotenuse. ");
            }

            else
            {
                double x = Convert.ToDouble(___inputBoxa___Copy.Text) / Convert.ToDouble(___inputBoxb___Copy.Text);
                ___endProductBox__Copy.Text = Convert.ToString(Math.Cos(Math.PI / 180 * x));
            }
        }



        private void TanButton(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa___Copy1.Text == "")
            {
                MessageBox.Show("Enter value for opposite. ");
            }


            else if (___inputBoxb___Copy1.Text == "")
            {
                MessageBox.Show("Enter value for adjacent. ");
            }

            else
            {
                double x = Convert.ToDouble(___inputBoxa__.Text) / Convert.ToDouble(___inputBoxb__.Text);
                ___endProductBox__Copy1.Text = Convert.ToString(Math.Tan(Math.PI / 180 * x));
            }
        }
    }
}
