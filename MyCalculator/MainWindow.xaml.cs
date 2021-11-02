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

namespace MyCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class MyButton: Window
    {

    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void add1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = System.Convert.ToDouble(tb1.Text);
                double y = System.Convert.ToDouble(tb2.Text);
                double result = x + y;
                tb3.Text = System.Convert.ToString(result);
            }
            catch(Exception)
            {
                tb3.Text = "Wrong input";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = System.Convert.ToDouble(tb1.Text);
                double y = System.Convert.ToDouble(tb2.Text);
                double result = x - y;
                tb3.Text = System.Convert.ToString(result);
            }
            catch (Exception)
            {
                tb3.Text = "Wrong input";
            }

        }
    }
    
}
