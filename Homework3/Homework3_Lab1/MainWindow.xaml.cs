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

namespace Homework3_Lab1
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            const double INTEREST = 0.0639;

            double payment = double.Parse(monthlyPaymentTxt.Text);
            double balance = double.Parse(outstandingBalTxt.Text);

            double monthly_interest = (balance * INTEREST) / 12;
            //interest payment is paid first, either the value of the monthly interest or the entirety of what is paid
            double interest_payment = (monthly_interest < payment) ? monthly_interest : payment;
            //payment is updated (if payment provided is less than the monthly interest, there will be no money remaining
            //for principal, aka 0. otherwise, its the total difference minus the interest that has been paid
            payment = (payment < monthly_interest) ? 0: payment - monthly_interest;
            //whatever is left over is paid towards principal
            double principal_payment = payment;

            interestPaymentLabel.Content = "The amount that goes to interest is: " + interest_payment;
            principalPaymentLabel.Content = "The amount that goes to principal is: " + principal_payment;
        }
    }
}