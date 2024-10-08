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

namespace Week7Lab1
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

        private void calcButtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int operation = listBox.SelectedIndex;
                decimal left = Convert.ToDecimal(leftTxt.Text);
                decimal right = Convert.ToDecimal(rightTxt.Text);
                decimal result = 0;
                switch(operation)
                {
                    case 0:
                        result = left + right;
                        break;
                    case 1:
                        result = left - right;
                        break;
                    case 2:
                        result = left * right;
                        break;
                    case 3:
                        result = left / right;
                        break;
                    case 4:
                        result = left % right;
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operation selected");
                        break;
                }
                resultTxt.Text = Convert.ToString(result);
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error: can not divide by zero");
            }
            catch(FormatException)
            {
                MessageBox.Show("Error: invalid decimal number");
            }
        }
    }
}