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
    /// Interaction logic for Pythag.xaml
    /// </summary>
    public partial class Pythag : Page
    {
        public Pythag()
        {
            InitializeComponent();
        }



        private void helpClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Help());
            this.Frame.Navigate(new Uri("Help.xaml", UriKind.Relative));
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PythagInfo.txt");
            File.Write(___informationBox_.Text);
            File.Close();

            Frame.Navigate(new geometry());
            this.Frame.Navigate(new Uri("geometry.xaml", UriKind.Relative));
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("PythagInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();
        }


        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            ___informationBox_.Text = File.ReadAllText("PythagInfo.txt");//retreives the file from bin, debug. 
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa__.Text == "" && ___inputBoxb__.Text != "" && ___inputBoxc__.Text != "")
            {
                //a = c - b
                double b = Convert.ToDouble(___inputBoxb__.Text);
                double c = Convert.ToDouble(___inputBoxc__.Text);
                ___endProductBox_.Text = Convert.ToString(Math.Sqrt((c * c) - (b * b)));
            }

            else if (___inputBoxa__.Text != "" && ___inputBoxb__.Text == "" && ___inputBoxc__.Text != "")
            {
                //b = c - a
                double a = Convert.ToDouble(___inputBoxa__.Text);
                double c = Convert.ToDouble(___inputBoxc__.Text);
                ___endProductBox_.Text = Convert.ToString(Math.Sqrt((c * c) - (a * a)));
            }

            else if (___inputBoxa__.Text != "" && ___inputBoxb__.Text != "" && ___inputBoxc__.Text == "")
            {
                //a = b = c
                double a = Convert.ToDouble(___inputBoxa__.Text);
                double b = Convert.ToDouble(___inputBoxb__.Text); 
                ___endProductBox_.Text = Convert.ToString(Math.Sqrt((a * a) + (b * b)));
            }

            else
            {
                MessageBox.Show("input properly");
            }


        }
    }
}
