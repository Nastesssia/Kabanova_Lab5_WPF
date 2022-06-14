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

namespace Kabanova_Lab5_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Linear linear;
        private Square square;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            linear = new Linear(double.Parse(AL.Text), double.Parse(BL.Text));
            RES1.Text = 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            square = new Square(double.Parse(AS.Text), double.Parse(BS.Text), double.Parse(CS.Text));
            RES2.Text = ;
        }
    }
}
