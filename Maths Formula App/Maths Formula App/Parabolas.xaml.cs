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
            double a = Convert.ToDouble(___inputBoxa__.Text);
            double b = Convert.ToDouble(___inputBoxh__.Text);
            double c = Convert.ToDouble(___inputBoxk__.Text);

            double origin_x = ___theCanvas_.Width / 2;
            double origin_y = ___theCanvas_.Height / 2;

            for (var i = origin_x; i <= ___theCanvas_.Width; i += 1)
            {
                double y = a * i + b * i + c;
                
            }


            //List<int> nums = new List<int>();

                //for (var i = 0; i <= ___theCanvas_.Width; i += 1)
                //{
                //    nums.Add(i);
                //}



        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Exponentials_page());
            this.Frame.Navigate(new Uri("Exponentials_page.xaml", UriKind.Relative));
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
