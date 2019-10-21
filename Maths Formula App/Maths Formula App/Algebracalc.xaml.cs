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
    /// Interaction logic for Algebracalc.xaml
    /// </summary>
    public partial class Algebracalc : Page
    {
        public Algebracalc()
        {
            InitializeComponent();
        }
    
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(textBox1.Text.ToCharArray());
            textBox2.Text = MyMath.EvalExpression(textBox1.Text.ToCharArray()).ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ___backButton__Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(new IndecesSection());
            //this.Frame.Navigate(new Uri("IndecesSection.xaml", UriKind.Relative)); THIS MAKES ERRORS. 
        }
    }
}
