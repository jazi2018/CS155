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

namespace Lab_Week5
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
            double speed = double.Parse(speedInput.Text);
            double speedLimit = double.Parse(speedLimitInput.Text);
            if (speed <= speedLimit)
            {
                speedOutputLbl.Content = "You were not speeding.";
                speedCanvas.Background = Brushes.LightGreen;
            }
            else if (speed <= speedLimit + 25)
            {
                double difference = speed - speedLimit;
                double fine = difference * 7;
                string output = String.Format("You were speeding by {0} mph, which has a fine of ${1}, \nbut does not incur the $250 fine.",
                    difference, fine);
                speedOutputLbl.Content = output;
                speedCanvas.Background = Brushes.LemonChiffon;
            }
            else
            {
                double difference = speed - speedLimit;
                double fine = difference * 7 + 250;
                string output = String.Format("You were speeding by {0} mph, incuring a total fine of ${1}", difference, fine);
                speedOutputLbl.Content = output;
                speedCanvas.Background = Brushes.LightCoral;
            }
        }
    }
}