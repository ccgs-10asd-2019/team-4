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
    /// Interaction logic for Exponentials_Notes.xaml
    /// </summary>
    public partial class Parabola_Notes : Page
    {
        public Parabola_Notes()
        {
            InitializeComponent();
            var text = File.ReadAllText("ParabolaInfo.txt");//retreives the file from bin, debug. 
        }

        private void ___save_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("ParabolaInfo.txt");
            File.Write(___informationBox_.Text);
            File.Close();
        }

        private void ___load_file__Click(object sender, RoutedEventArgs e)
        {
            var text = File.ReadAllText("ParabolaInfo.txt");//retreives the file from bin, debug. 
            ___informationBox_.Text = text;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Personal());
            this.Frame.Navigate(new Uri("Personal.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
