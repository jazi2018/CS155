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

namespace Homework3_Part1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String first_name = firstNameTxt.Text;
            String last_name = lastNameTxt.Text;

            first_name = ToPigLatin(first_name);
            last_name = ToPigLatin(last_name);

            MessageBox.Show("Your name in pig latin is: " + first_name + " " + last_name);
        }
        static string ToPigLatin(string word)
        {
            string pl_word = word.Substring(1).ToLower(); //copies the string, but ignoring the first letter
            pl_word += Char.ToLower(word[0]); //take first letter of word and concatenate to end of substring
            pl_word += "ay"; //add ay to the end to finalize our word
            pl_word = Char.ToUpper(pl_word[0]) + pl_word.Substring(1); //capitalizes the first letter
            return pl_word;
        }
    }
}