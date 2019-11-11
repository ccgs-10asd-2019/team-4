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
    /// Interaction logic for Indicies.xaml
    /// </summary>
    public partial class Indicies : Page
    {
        public Indicies()
        {
            InitializeComponent();

            ___informationBox_.Text = File.ReadAllText("IndicesInfo.txt");//C:\\User Program Files\\anything you want\\team-4\\Maths Formula App\\
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            if (___inputBoxa__.Text == "")
            {
                MessageBox.Show("input something. ");
            }


            else if (___inputBoxb__.Text == "")
            {
                MessageBox.Show("input something. ");
            }

            
            else
            {

                double basee = Convert.ToDouble(___inputBoxa__.Text);
                double power = Convert.ToDouble(___inputBoxb__.Text);

                double product = Math.Pow(basee, power);

                ___endProductBox_.Text = Convert.ToString(product);
            }
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("IndicesInfo.txt");//puts the file in the bin, debug. 
            File.Write(___informationBox_.Text);
            File.Close();

            Frame.Navigate(new IndecesSection());
            this.Frame.Navigate(new Uri("IndecesSection.xaml", UriKind.Relative));
        }

        private void helpClick(object sender, RoutedEventArgs e)
        {

        }

        private void ___FillButtonClick_(object sender, RoutedEventArgs e)
        {
            ___informationBox_.Text = File.ReadAllText("IndicesInfo.txt");//C:\\User Program Files\\anything you want\\team-4\\Maths Formula App\\
        }

        private void ___create_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("IndicesInfo.txt");
            File.Write(___informationBox_.Text);
            File.Close();
        }
    }
}
