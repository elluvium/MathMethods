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

namespace MathMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedItem == number2)
            {
                Gauss2 gauss2 = new Gauss2();
                gauss2.Show();
            }

            if (comboBox1.SelectedItem == number3)
            {
                Gauss3 gauss3 = new Gauss3();
                gauss3.Show();
            }

            if (comboBox1.SelectedItem == number4)
            {
                Gauss4 gauss4 = new Gauss4();
                gauss4.Show();
            }

        }

        
    }
}
