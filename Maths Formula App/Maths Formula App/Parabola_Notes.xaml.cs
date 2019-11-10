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
    public partial class Exponentials_Notes : Page
    {
        public Exponentials_Notes()
        {
            InitializeComponent();
            var text = File.ReadAllText("C:\\User Program Files\\Github Maths Formula App 2\\team-4\\Maths Formula App\\ParabolaInfo.txt");//retreives the file from bin, debug. 
        }

        private void ___save_file__Click(object sender, RoutedEventArgs e)
        {
            StreamWriter File = new StreamWriter("C:\\User Program Files\\Github Maths Formula App 2\\team-4\\Maths Formula App\\ParabolaInfo.txt");
            File.Write(___informationBox_.Text);
            File.Close();
        }

        private void ___load_file__Click(object sender, RoutedEventArgs e)
        {
            var text = File.ReadAllText("C:\\User Program Files\\Github Maths Formula App 2\\team-4\\Maths Formula App\\ParabolaInfo.txt");//retreives the file from bin, debug. 
            ___informationBox_.Text = text;
        }
    }
}
