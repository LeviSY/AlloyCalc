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
using System.Runtime.CompilerServices;

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

        private void metal1_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double slider1 = metal1_slider.Value;
            double slider2 = metal2_slider.Value;
            double slider3 = metal3_slider.Value;

            if (slider1+slider2 != (double)100)
            {
                metal2_slider.Value = (double)100 - slider1;
            }
        }
    }
}
