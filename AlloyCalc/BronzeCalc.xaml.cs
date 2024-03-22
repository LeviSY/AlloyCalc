using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Text.RegularExpressions;

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

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e) //textbox only numbers
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        void all_metal_sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) //sliders balancing
        {
            if (lockChanges)
                return;
            lockChanges = true;
            if (metal1_slider != null && metal2_slider != null && metal3_slider != null)
            {
                if (sender == metal1_slider)
                {
                    metal2_slider.Value = 100 - (metal1_slider.Value + metal3_slider.Value);
                    metal3_slider.Value = 100 - (metal1_slider.Value + metal2_slider.Value);
                }
                if (sender == metal2_slider)
                {
                    metal1_slider.Value = 100 - (metal2_slider.Value + metal3_slider.Value);
                    metal3_slider.Value = 100 - (metal2_slider.Value + metal1_slider.Value);
                }
                if (sender == metal3_slider)
                {
                    metal1_slider.Value = 100 - (metal3_slider.Value + metal2_slider.Value);
                    metal2_slider.Value = 100 - (metal3_slider.Value + metal1_slider.Value);
                }
                lockChanges = false;
            }
        }

        private void AlloySelection_SelectionChanged(object sender, SelectionChangedEventArgs e) //metal icons
        {
            if (lockChanges)
                return;
            lockChanges = true;
            if (AlloySelection.SelectedIndex == 0)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/copper.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/tin.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 1)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/copper.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/zinc.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/bismuth.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 2)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/copper.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/silver.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/gold.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 3)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/copper.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/zinc.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 4)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/lead.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/tin.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 5)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/copper.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/lead.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 6)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/silver.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/tin.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            if (AlloySelection.SelectedIndex == 7)
            {
                metal1_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/gold.png");
                metal2_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/silver.png");
                metal3_image.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(@"resources/missing_image.png");
                TotalAlloyValue.Text = "";
                TotalAlloyValue.Focus();
                metal_cost1.Content = "0";
                metal_cost2.Content = "0";
                metal_cost3.Content = "0";
            }
            all_sliders_changes();
            lockChanges = false;
        }

        private void all_sliders_changes() //sliders properties
        {
            if (AlloySelection.SelectedIndex == 0)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [89, 90, 91];
                metal1_slider.Minimum = 88;
                metal1_slider.Maximum = 92;
                metal1_slider.Value = 88;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [9, 10, 11];
                metal2_slider.Minimum = 8;
                metal2_slider.Maximum = 12;
                metal2_slider.Value = 12;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;
            }
            if (AlloySelection.SelectedIndex == 1)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69];
                metal1_slider.Minimum = 50;
                metal1_slider.Maximum = 70;
                metal1_slider.Value = 50;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [21, 22, 23, 24, 25, 26, 27, 28, 29];
                metal2_slider.Minimum = 20;
                metal2_slider.Maximum = 30;
                metal2_slider.Value = 30;

                metal3_slider.IsEnabled = true;
                metal3_slider.Ticks = [11, 12, 13, 14, 15, 16, 17, 18, 19];
                metal3_slider.Minimum = 10;
                metal3_slider.Maximum = 20;
                metal3_slider.Value = 20;
            }
            if (AlloySelection.SelectedIndex == 2)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83];
                metal1_slider.Minimum = 68;
                metal1_slider.Maximum = 84;
                metal1_slider.Value = 68;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [9, 10, 11, 12, 13, 14, 15];
                metal2_slider.Minimum = 8;
                metal2_slider.Maximum = 16;
                metal2_slider.Value = 16;

                metal3_slider.IsEnabled = true;
                metal3_slider.Ticks = [9, 10, 11, 12, 13, 14, 15];
                metal3_slider.Minimum = 8;
                metal3_slider.Maximum = 16;
                metal3_slider.Value = 16;
            }
            if (AlloySelection.SelectedIndex == 3)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [61, 62, 63, 64, 65, 66, 67, 68, 69];
                metal1_slider.Minimum = 60;
                metal1_slider.Maximum = 70;
                metal1_slider.Value = 40;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [31, 32, 33, 34, 35, 36, 37, 38, 39];
                metal2_slider.Minimum = 30;
                metal2_slider.Maximum = 40;
                metal2_slider.Value = 30;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;

            }
            if (AlloySelection.SelectedIndex == 4)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [46, 47, 48, 49, 50, 51, 52, 53, 54];
                metal1_slider.Minimum = 45;
                metal1_slider.Maximum = 55;
                metal1_slider.Value = 45;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [46, 47, 48, 49, 50, 51, 52, 53, 54];
                metal2_slider.Minimum = 45;
                metal2_slider.Maximum = 55;
                metal2_slider.Value = 55;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;
            }
            if (AlloySelection.SelectedIndex == 5)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [9, 10, 11];
                metal1_slider.Minimum = 8;
                metal1_slider.Maximum = 12;
                metal1_slider.Value = 12;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [89, 90, 91];
                metal2_slider.Minimum = 88;
                metal2_slider.Maximum = 92;
                metal2_slider.Value = 88;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;
            }
            if (AlloySelection.SelectedIndex == 6)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [41, 42, 43, 44, 45, 46, 47, 48, 49];
                metal1_slider.Minimum = 40;
                metal1_slider.Maximum = 50;
                metal1_slider.Value = 40;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [51, 52, 53, 54, 55, 56, 57, 58, 59];
                metal2_slider.Minimum = 50;
                metal2_slider.Maximum = 60;
                metal2_slider.Value = 60;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;
            }
            if (AlloySelection.SelectedIndex == 7)
            {
                metal1_slider.IsEnabled = true;
                metal1_slider.Ticks = [41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59];
                metal1_slider.Minimum = 40;
                metal1_slider.Maximum = 60;
                metal1_slider.Value = 40;

                metal2_slider.IsEnabled = true;
                metal2_slider.Ticks = [41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59];
                metal2_slider.Minimum = 40;
                metal2_slider.Maximum = 60;
                metal2_slider.Value = 60;

                metal3_slider.IsEnabled = false;
                metal3_slider.Ticks = [0];
                metal3_slider.Minimum = 0;
                metal3_slider.Maximum = 0;
                metal3_slider.Value = 0;

            }
        }

        private void TotalAlloyValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TotalAlloyValue.Text == "")
            {
                TotalAlloyValue.Text = "0";
                TotalAlloyValue.SelectAll();
            }

            metal_cost1.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal1_label.Content)),0);
            metal_cost2.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal2_label.Content)),0);
            metal_cost3.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal3_label.Content)),0);
        }

        private void all_sliders_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            if(TotalAlloyValue.Text != "0" && TotalAlloyValue.Text != "")
            {
                metal_cost1.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal1_label.Content)), 0);
                metal_cost2.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal2_label.Content)), 0);
                metal_cost3.Content = Math.Round(Convert.ToDouble(TotalAlloyValue.Text) * Convert.ToDouble("0," + Convert.ToString(metal3_label.Content)), 0);
            }
            
        }
    }
}
