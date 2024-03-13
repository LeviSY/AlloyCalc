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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Printing;
using System.Collections.ObjectModel;

namespace AlloyCalc
{
    /// <summary>
    /// Interaction logic for BronzeCalc.xaml
    /// </summary>
    public partial class BronzeCalc : Window
    {
        
        public BronzeCalc()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AlloySelection.Items.Add("Tin Bronze");
            AlloySelection.Items.Add("Bismuth Bronze");
            AlloySelection.Items.Add("Black Bronze");
            AlloySelection.Items.Add("Brass");
        }


    }
}
