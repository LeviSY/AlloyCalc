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
using System.IO;

namespace AlloyCalc
{
    /// <summary>
    /// Interaction logic for BronzeCalc.xaml
    /// </summary>
    public partial class BronzeCalc : Window
    {
        bool lockChanges = false;


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
               
        void all_metal_sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (lockChanges)
                return;
            lockChanges = true;
            if (metal1_slider != null && metal2_slider != null && metal3_slider != null)
            {
                if (sender == metal1_slider)
                    metal2_slider.Value = 100 - (metal1_slider.Value + metal3_slider.Value);
                    metal3_slider.Value = 100 - (metal1_slider.Value + metal2_slider.Value);
                if (sender == metal2_slider)
                    metal1_slider.Value = 100 - (metal2_slider.Value + metal3_slider.Value);
                    metal3_slider.Value = 100 - (metal1_slider.Value + metal2_slider.Value);
                if (sender == metal3_slider)
                    metal1_slider.Value = 100 - (metal2_slider.Value + metal3_slider.Value);
                    metal2_slider.Value = 100 - (metal1_slider.Value + metal3_slider.Value);

            }
            if (metal1_slider != null && metal2_slider != null)
            {
                if (sender == metal1_slider)
                    metal2_slider.Value = 100 - metal1_slider.Value;
                if (sender == metal2_slider)
                    metal1_slider.Value = 100 - metal2_slider.Value;
            }
            lockChanges = false;
        }
        

        
    }
}
