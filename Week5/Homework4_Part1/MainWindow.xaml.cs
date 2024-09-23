using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Homework4_Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(weightInput.Text);
            double height = double.Parse(heightInput.Text);

            double bmi = (weight * 720) / Math.Pow(height, 2.0);

            if (bmi < 15)
            {
                bmiOutput.Content = String.Format("Your bmi is {0:0.00}. \nYou are below the healthy range.", bmi);
                bmiCanvas.Background = Brushes.PowderBlue;
            }
            else if (bmi >= 15 && bmi <= 26)
            {
                bmiOutput.Content = String.Format("Your bmi is {0:0.00}. \nYou are within the healthy range.", bmi);
                bmiCanvas.Background = Brushes.PaleGreen;
            }
            else
            {
                bmiOutput.Content = String.Format("Your bmi is {0:0.00}. \nYou are above the healthy range.", bmi);
                bmiCanvas.Background = Brushes.LightCoral;
            }
        }
    }
}