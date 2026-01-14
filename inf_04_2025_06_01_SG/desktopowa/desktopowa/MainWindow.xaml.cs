using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace desktopowa
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

        private void SliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Update();
        }

        private void SliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Update();
        }

        private void SliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Update();
        }

        private void ReadValueButton_Click(object sender, RoutedEventArgs e)
        {
            if (!IsInitialized)
            {
                return;
            }

            var color = GetColor();
            RGBValueText.Text = $"{color.R}, {color.G}, {color.B}";
            RGBValueText.Background = new SolidColorBrush(color);
        }

        private void Update()
        {
            if(!IsInitialized)
            { 
                return; 
            }

            var color = GetColor();
            
            ColorBorder.Background = new SolidColorBrush(color);

            LabelR.Content = color.R;
            LabelG.Content = color.G;
            LabelB.Content = color.B;
        }


        private Color GetColor()
        {
            var r = (byte)SliderR.Value;
            var g = (byte)SliderG.Value;
            var b = (byte)SliderB.Value;


            return Color.FromRgb(r, g, b);
        }
    }
}