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
using Mathematical.Expressions;

namespace Maths_Formula_App
{
    /// <summary>
    /// Interaction logic for algebra_calc.xaml
    /// </summary>
    public partial class algebra_calc : Page
    {
        public algebra_calc()
        {
            InitializeComponent();
        }

  
        private void btn_calculate(object sender, RoutedEventArgs e)
        {
            List<MyMath> list = dataGridView.DataContext as List<MyMath>;
            if (list != null)
            {
                foreach(MyMath math in list)
                {
                    ExpressionEval eval = new ExpressionEval(math.formula);
                    eval.SetVariable("a", math.a);
                    eval.SetVariable("b", math.b);
                    eval.SetVariable("c", math.c);
                    math.result = (double)eval.Evaluate();
                }
                dataGridView.DataContext = list;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<MyMath> list = new List<MyMath>();
            list.Add(new MyMath() { a = 2.1, b = 3, c = 4.6 });
            list.Add(new MyMath() { a = 2.1, b = 3, c = 4.6 });
            list.Add(new MyMath() { a = 2.1, b = 3, c = 4.6 });
            list.Add(new MyMath() { a = 2.1, b = 3, c = 4.6 });
            dataGridView.DataContext = list;
        }
    }
}
