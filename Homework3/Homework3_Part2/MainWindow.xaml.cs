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

namespace Homework3_Part2
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
            int price_input = Int32.Parse(priceText.Text);
            int quarters, dimes, nickels;

            int change = 100 - price_input;

            quarters = change / 25;
            change %= 25;
            dimes = change / 10;
            change %= 10;
            nickels = change / 5;
            change %= 5;

            quarterLabel.Content = quarters.ToString() + " quarters.";
            dimeLabel.Content = dimes.ToString() + " dimes.";
            nickelLabel.Content = nickels.ToString() + " nickels.";
        }
    }
}